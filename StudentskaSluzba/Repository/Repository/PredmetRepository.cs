using StudentskaSluzba.Models;
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

        public IEnumerable<Predmet> GetPredmetiForProfesor(string profesorId)
        {
            int profId = db.Profesori.Where(x => x.Email == profesorId).ToList()[0].Id;

            List<Predmet> predmeti = new List<Predmet>();
            foreach(Predmet p in db.Predmeti.ToList())
            {
                if (p.ProfesorId == profId)
                {
                    p.Profesor = null;
                    predmeti.Add(p);
                }
            }
            return predmeti;
        }
    }
}