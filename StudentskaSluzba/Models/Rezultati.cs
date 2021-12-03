using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models
{
    [Table("Rezultati")]
    public class Rezultati
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetId { get; set; }
        public int Rok { get; set; }
        public double PredispitniPoeni { get; set; }
        public double IspitniPoeni { get; set; }
        public int Ocena { get; set; }

        public Rezultati()
        {

        }

        public Rezultati(int studentId, int predmetId, int rok, double predispitniPoeni, double ispitniPoeni, int ocena)
        {
            StudentId = studentId;
            PredmetId = predmetId;
            Rok = rok;
            PredispitniPoeni = predispitniPoeni;
            IspitniPoeni = ispitniPoeni;
            Ocena = ocena;
        }
    }
}