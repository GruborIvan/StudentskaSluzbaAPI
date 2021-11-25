using StudentskaSluzba.Models;
using StudentskaSluzba.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Repository.Repository
{
    public class AuthRepository : IAuthRepository
    {
        ApplicationDbContext db;

        public AuthRepository()
        {
            db = new ApplicationDbContext();
        }

        public bool ProfesorLogIn(string email, string password)
        {
            List<Profesor> profesori = db.Profesori.ToList();
            foreach(Profesor p in profesori)
            {
                if (p.Email == email && p.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool StudentLogIn(string brojIndeksa, string password)
        {
            List<Student> studenti = db.Studenti.ToList();
            foreach(Student s in studenti)
            {
                if (s.BrojIndeksa == brojIndeksa && s.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}