using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("TokoviStudija")]
    public class TokStudija
    {
        public int Id { get; set; }
        public DateTime DatumUpisa { get; set; }
        public string Godina { get; set; }
        public string BrojUpisa { get; set; }
        public bool Budzet { get; set; }
        public ICollection<Student> Students { get; set; }

        public TokStudija()
        {

        }
    }
}