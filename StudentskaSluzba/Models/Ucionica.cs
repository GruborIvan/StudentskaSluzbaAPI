using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("Ucionice")]
    public class Ucionica
    {
        public int Id { get; set; }
        public string Zgrada { get; set; }
        public string BrojUcionice { get; set; }
        public ICollection<Ispit> Ispiti { get; set; }

        public Ucionica()
        {

        }
    }
}