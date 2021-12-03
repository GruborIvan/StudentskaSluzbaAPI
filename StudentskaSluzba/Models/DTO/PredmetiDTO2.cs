using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class PredmetiDTO2
    {
        public int Id { get; set; }
        public string NazivPredmeta { get; set; }
        public string SifraPredmeta { get; set; }
        public int BrojESPB { get; set; }
        public string ImeProfesora { get; set; }
        public string DatumIspita { get; set; }
        public Rezultati Rezultati { get; set; }
        public int RokId { get; set; }
        public string NazivRoka { get; set; }

        public PredmetiDTO2(int id, string nazivPredmeta, string sifraPredmeta, int brojESPB, string imeProfesora, int rokId)
        {
            Id = id;
            NazivPredmeta = nazivPredmeta;
            SifraPredmeta = sifraPredmeta;
            BrojESPB = brojESPB;
            ImeProfesora = imeProfesora;
            RokId = rokId;
        }
    }
}