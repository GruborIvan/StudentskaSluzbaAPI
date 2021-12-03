using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("Predmeti")]
    public class Predmet
    {
        public int Id { get; set; }
        public string NazivPredmeta { get; set; }
        public string SifraPredmeta { get; set; }
        public int BrojESPB { get; set; }
        public Profesor Profesor { get; set; }
        public int ProfesorId { get; set; }
        public virtual ICollection<Ispit> Ispiti { get; set; }
        public virtual ICollection<Rezultati> Rezultati { get; set; }

        public Predmet()
        {

        }
    }
}