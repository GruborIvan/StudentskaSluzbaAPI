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

        public bool ProfesorChangePassword(string emailProfesora, string newPassword)
        {
            int profesorId = db.Profesori.Where(x => x.Email == emailProfesora).FirstOrDefault().Id;
            Profesor p = db.Profesori.Find(profesorId);
            p.Password = newPassword;
            db.Entry<Profesor>(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return true;
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

        public void StudentChangePassword(string brojIndeksa, string newPassword)
        {
            int studentId = db.Studenti.Where(x => x.BrojIndeksa == brojIndeksa).FirstOrDefault().Id;
            Student s = db.Studenti.Find(studentId);
            s.Password = newPassword;
            db.Entry<Student>(s).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
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