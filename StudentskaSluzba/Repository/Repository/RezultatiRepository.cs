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

        public IEnumerable<PredmetiDTO> GetPolozeniPredmeti(string brojIndeksa,int mode)
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
                dtos = dtos.Where(x => x.Rezultati == null).ToList();
            }
            else
            {
                dtos = dtos.Where(x => x.Rezultati != null).ToList();
            }
            return dtos;
        }
    }
}