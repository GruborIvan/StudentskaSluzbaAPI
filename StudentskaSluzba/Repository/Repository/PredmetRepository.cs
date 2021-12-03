using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using StudentskaSluzba.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Repository.Repository
{
    public class PredmetRepository : IPredmetRepository
    {
        ApplicationDbContext db;

        public PredmetRepository()
        {
            db = new ApplicationDbContext();
        }

        public IEnumerable<PredmetiDTO2> GetPredmetiForProfesor(string profesorId)
        {
            int profId = db.Profesori.Where(x => x.Email == profesorId).ToList()[0].Id;

            List<PredmetiDTO2> predmeti = new List<PredmetiDTO2>();
            foreach(Predmet p in db.Predmeti.ToList())
            {
                if (p.ProfesorId == profId)
                {
                    PredmetiDTO2 dto = new PredmetiDTO2(p.Id,p.NazivPredmeta,p.SifraPredmeta,p.BrojESPB,p.Profesor.Ime + " " + p.Profesor.Prezime,0);
                    predmeti.Add(dto);
                }
            }
            return predmeti;
        }
    }
}