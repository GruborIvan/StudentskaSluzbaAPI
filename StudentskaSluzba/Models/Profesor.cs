using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("Profesori")]
    public class Profesor
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Citiranost { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<ZvanjeProfesora> Zvanja { get; set; }
        public ICollection<Predmet> Predmeti { get; set; }

        public Profesor()
        {

        }
    }
}