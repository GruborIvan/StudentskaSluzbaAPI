using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("Adrese")]
    public class Adresa
    {
        public int Id { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }

        public Adresa()
        {

        }

        public Adresa(int id, string grad, string ulica, string broj)
        {
            Id = id;
            Grad = grad;
            Ulica = ulica;
            Broj = broj;
        }
    }
}