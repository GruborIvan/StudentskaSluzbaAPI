using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("IspitniRokovi")]
    public class IspitniRok
    {
        public int Id { get; set; }
        public string NazivRoka { get; set; }
        public DateTime DatumPocetkaRoka { get; set; }
        public DateTime DatumKrajaRoka { get; set; }
        public ICollection<Ispit> Ispiti { get; set; }

        public IspitniRok()
        {

        }

    }
}