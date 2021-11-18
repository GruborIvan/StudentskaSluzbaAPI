using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("Ispiti")]
    public class Ispit
    {
        public int Id { get; set; }
        public DateTime DatumIVremeOdrzavanja { get; set; }
        public Ucionica Ucionica { get; set; }
        public int UcionicaId { get; set; }
        public ICollection<Student> Studenti { get; set; }
        public ICollection<IspitniRok> IspitniRokovi { get; set; }
        public ICollection<Predmet> Predmeti { get; set; }

        public Ispit()
        {

        }
    }
}