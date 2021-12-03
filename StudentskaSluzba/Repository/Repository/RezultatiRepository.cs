using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using StudentskaSluzba.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Repository.Repository
{
    public class RezultatiRepository : IRezultatiRepository
    {
        ApplicationDbContext db;

        public RezultatiRepository()
        {
            db = new ApplicationDbContext();
        }

        public IEnumerable<PredmetiDTO> GetPolozeniPredmeti(string brojIndeksa,int mode,int ispitniRokId)
        {
            // Student
            Student s = db.Studenti.Where(x => x.BrojIndeksa == brojIndeksa).FirstOrDefault();

            List<PredmetiDTO> dtos = new List<PredmetiDTO>();
            List<Predmet> predmeti = db.Predmeti.ToList();
            foreach(Predmet p in predmeti)
            {
                p.Profesor = db.Profesori.Find(p.ProfesorId);
                PredmetiDTO dto = new PredmetiDTO(p.Id, p.NazivPredmeta, p.SifraPredmeta, p.BrojESPB, p.Profesor.Ime + " " + p.Profesor.Prezime);
                dto.Rezultati = p.Rezultati.Where(x => x.StudentId == s.Id).Where(x => x.PredmetId == p.Id).FirstOrDefault();
                dtos.Add(dto);
            }
            if (mode == 1)
            {
                dtos = dtos.Where(x => x.Rezultati == null || x.Rezultati.Ocena == 5).ToList();
                List<Rezultati> rez = db.Rezultati.Where(x => x.Rok == ispitniRokId).Where(x => x.StudentId == s.Id).ToList(); 

                foreach(PredmetiDTO dto in dtos)
                {
                    Rezultati r = rez.Where(x => x.PredmetId == dto.Id).FirstOrDefault();
                    if (r != null)
                    {
                        dto.Rezultati = r;
                    }

                    if (dto.Rezultati != null)
                    {
                        if (dto.Rezultati.Rok != ispitniRokId)
                        {
                            dto.Rezultati = null;
                        }
                        else
                        {
                            dto.Rezultati.Predmet = null;
                            dto.Rezultati.Student = null;
                        }
                    }

                    dto.DatumIspita = db.Ispiti
                                            .Where(x => x.PredmetId == dto.Id)
                                            .Where(x => x.IspitniRokId == ispitniRokId)
                                            .FirstOrDefault()
                                            .DatumIVremeOdrzavanja.ToString("dd.MM.yyyy");
                }
            }
            else
            {
                dtos = dtos.Where(x => x.Rezultati != null).Where(x => x.Rezultati.Ocena > 5).ToList();
                foreach(PredmetiDTO dto in dtos)
                {
                    dto.Ocena = db.Rezultati.Where(x => x.PredmetId == dto.Id).Where(x => x.StudentId == s.Id).FirstOrDefault().Ocena;
                    dto.Rezultati.Student = null;
                    dto.Rezultati.Predmet = null;
                }
            }
            return dtos;
        }

        public void PostOcena(OcenaPostDTO dto)
        {
            int ocena = GetOcena(dto.PredispitniPoeni,dto.IspitniPoeni);
            Rezultati rezultat = db.Rezultati
                                        .Where(x => x.PredmetId == dto.PredmetId)
                                        .Where(x => x.StudentId == dto.StudentId)
                                        .Where(x => x.Rok == dto.RokId)
                                        .FirstOrDefault();
            if (rezultat != null)
            {
                rezultat.PredispitniPoeni = dto.PredispitniPoeni;
                rezultat.IspitniPoeni = dto.IspitniPoeni;
                rezultat.Ocena = GetOcena(dto.PredispitniPoeni, dto.IspitniPoeni);
                db.Entry<Rezultati>(rezultat).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private int GetOcena(double predispitni,double ispitni)
        {
            double sumaInt = predispitni + ispitni;
            if (sumaInt < 61)
                return 6;
            else if (sumaInt < 71)
                return 7;
            else if (sumaInt < 81)
                return 8;
            else if (sumaInt < 91)
                return 9;
            else
                return 10;
        }

    }
}