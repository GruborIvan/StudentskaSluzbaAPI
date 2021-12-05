using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using StudentskaSluzba.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Repository.Repository
{
    public class IspitRepository : IIspitRepository
    {
        ApplicationDbContext db;

        public IspitRepository()
        {
            db = new ApplicationDbContext();
        }

        public IEnumerable<PredmetiDTO2> GetPrijavljeniIspiti(string brojIndeksa)
        {
            List<PredmetiDTO2> ret = new List<PredmetiDTO2>();
            int studentId = db.Studenti.Where(x => x.BrojIndeksa == brojIndeksa).FirstOrDefault().Id;
            List<Rezultati> rez = db.Rezultati.Where(x => x.StudentId == studentId).Where(x => x.Ocena == 5).ToList();
            foreach(Rezultati r in rez)
            {
                Predmet p = db.Predmeti.Find(r.PredmetId);
                p.Profesor = db.Profesori.Find(p.ProfesorId);
                PredmetiDTO2 dto = new PredmetiDTO2(p.Id,p.NazivPredmeta,p.SifraPredmeta,p.BrojESPB,p.Profesor.Ime + " " + p.Profesor.Prezime,r.Rok);
                ret.Add(dto);
            }
            foreach(PredmetiDTO2 d in ret)
            {
                d.DatumIspita = db.Ispiti
                                            .Where(x => x.PredmetId == d.Id)
                                            .Where(x => x.IspitniRokId == d.RokId)
                                            .FirstOrDefault()
                                            .DatumIVremeOdrzavanja.ToString("dd.MM.yyyy");

                d.NazivRoka = db.IspitniRokovi.Find(d.RokId).NazivRoka;
            }
            return ret;
        }

        public void PrijavaIspita(string studentId, int ispitId,int ispitniRokId)
        {
            int studentId2 = db.Studenti.Where(x => x.BrojIndeksa == studentId).FirstOrDefault().Id;

            List<Rezultati> rezs = db.Rezultati.Where(x => x.StudentId == studentId2).Where(x => x.PredmetId == ispitId).Where(x => x.Rok == ispitniRokId).ToList();
            if (rezs.Count != 0)
                return;
            
            Rezultati rez = new Rezultati(studentId2,ispitId,ispitniRokId,0,0,5);
            db.Rezultati.Add(rez);
            db.SaveChanges();
        }

        public bool OdjavaIspita(string brojIndeksa, int predmetId, int ispitniRokId)
        {
            int studentId = db.Studenti.Where(x => x.BrojIndeksa == brojIndeksa).FirstOrDefault().Id;
            List<Rezultati> rezultati = db.Rezultati
                                            .Where(x => x.StudentId == studentId)
                                            .Where(x => x.PredmetId == predmetId)
                                            .ToList();
            if (rezultati.Count == 0)
            {
                return false;
            }

            db.Rezultati.Remove(rezultati[0]);
            db.SaveChanges();
            return true;
        }

    }
}