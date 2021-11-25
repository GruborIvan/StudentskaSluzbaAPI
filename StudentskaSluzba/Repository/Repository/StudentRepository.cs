using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using StudentskaSluzba.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Repository.Repository
{
    public class StudentRepository : IStudentRepository
    {
        ApplicationDbContext db;

        public StudentRepository()
        {
            db = new ApplicationDbContext();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public StudentDTO GetStudentByBrojIndeksa(string brojIndeksa)
        {
            List<Student> studenti = db.Studenti.Where(x => x.BrojIndeksa == brojIndeksa).ToList();
            if (studenti.Count > 0)
            {
                Student std = studenti[0];
                StudentDTO dto = new StudentDTO(std.Id, std.Ime, std.Prezime, std.BrojIndeksa, std.Password, std.AdresaId);
                dto.Adresa = db.Adrese.Find(std.AdresaId);
                return dto;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Student> GetStudentsKojiSuPoloziliPredmet(int predmetId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TokStudija> GetUspehStudenta(string brojIndeksa)
        {
            int studentId = db.Studenti.Where(x => x.BrojIndeksa == brojIndeksa).ToList()[0].Id;
            Student s = db.Studenti.Find(studentId);
            foreach(TokStudija ts in s.TokStudija)
            {
                ts.Students = null;
            }
            return s.TokStudija;
        }
    }
}