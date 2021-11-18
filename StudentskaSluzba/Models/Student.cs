using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Password { get; set; }
        public Adresa Adresa { get; set; }
        public int AdresaId { get; set; }
        public ICollection<TokStudija> TokStudija { get; set; }
        public ICollection<Ispit> PrijavljeniIspiti { get; set; } 
        public ICollection<Rezultati> Rezultati { get; set; }

        public Student()
        {

        }

        public Student(int id, string ime, string prezime, string brojIndeksa, Adresa adresa)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            BrojIndeksa = brojIndeksa;
            Adresa = adresa;
        }
    }
}