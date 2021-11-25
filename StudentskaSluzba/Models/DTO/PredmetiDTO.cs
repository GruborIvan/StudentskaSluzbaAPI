using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class PredmetiDTO
    {
        public int Id { get; set; }
        public string NazivPredmeta { get; set; }
        public string SifraPredmeta { get; set; }
        public int BrojESPB { get; set; }
        public string ImeProfesora { get; set; }
        public Rezultati Rezultati { get; set; }

        public PredmetiDTO(int id, string nazivPredmeta, string sifraPredmeta, int brojESPB, string imeProfesora)
        {
            Id = id;
            NazivPredmeta = nazivPredmeta;
            SifraPredmeta = sifraPredmeta;
            BrojESPB = brojESPB;
            ImeProfesora = imeProfesora;
        }
        
    }
}