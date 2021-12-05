using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("ZvanjaProfesora")]
    public class ZvanjeProfesora
    {
        public int Id { get; set; }
        public Zvanje Zvanje { get; set; }
        public DateTime DatumDobijanjaZvanja { get; set; }
        public DateTime DatumKrajaVazenjaZvanja { get; set; }
        public ICollection<Profesor> Profesori { get; set; }
    }

    public enum Zvanje
    {
        DOCENT,
        VANREDNI_PROFESOR,
        REDOVNI_PROFESOR
    }
}