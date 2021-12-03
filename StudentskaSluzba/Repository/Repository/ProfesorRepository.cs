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

        public IEnumerable<StudentDTO2> GetStudentiZaOcenjivanje(int predmetId,int idRok)
        {
            List<int> studentIds = new List<int>();
            List<int> idRokova = new List<int>();
            List<Rezultati> rezultati = db.Rezultati.Where(x => x.PredmetId == predmetId).Where(x => x.Ocena == 5).Where(x => x.Rok == idRok).ToList();
            foreach(Rezultati rez in rezultati)
            {
                studentIds.Add(rez.StudentId);
                idRokova.Add(rez.Rok);
            }

            List<StudentDTO2> retDTO = new List<StudentDTO2>();

            for (int i = 0; i < studentIds.Count; i++)
            {
                Student s = db.Studenti.Find(studentIds[i]);
                StudentDTO2 dto = new StudentDTO2(studentIds[i],s.Ime,s.Prezime,s.BrojIndeksa,s.Password,s.AdresaId,idRokova[i]);
                retDTO.Add(dto);
            }
            return retDTO;
        }
    }
}