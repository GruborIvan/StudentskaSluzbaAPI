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
        public virtual IspitniRok IspitniRok { get; set; }
        public int IspitniRokId { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetId { get; set; }

        public Ispit()
        {

        }
    }
}