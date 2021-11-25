using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using StudentskaSluzba.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Repository.Repository
{
    public class ProfesorRepository : IProfesorRepository
    {
        ApplicationDbContext db;

        public ProfesorRepository()
        {
            db = new ApplicationDbContext();
        }

        public IEnumerable<Profesor> GetProfesorForPredmet(int predmetId)
        {
            throw new NotImplementedException();
        }

        public Profesor GetProfesorByEmailAddress(string emailAddress)
        {
            List<Profesor> profs = db.Profesori.Where(x => x.Email == emailAddress).ToList();
            if (profs.Count > 0)
            {
                return profs[0];
            }
            else
            {
                return null;
            }
        }

        public string GetZvanjeForProfesor(int profesorId)
        {
            Profesor p = db.Profesori.Find(profesorId);
            if (p != null)
            {
                ZvanjeProfesora zvanje = p.Zvanja.OrderByDescending(x => x.DatumDobijanjaZvanja).FirstOrDefault();
                return zvanje.Zvanje.ToString();
            }
            return "";
        }
    }
}