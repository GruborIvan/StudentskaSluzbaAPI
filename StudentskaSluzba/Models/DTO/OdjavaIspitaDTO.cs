using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class OdjavaIspitaDTO
    {
        public string BrojIndeksa { get; set; }
        public int PredmetId { get; set; }
        public int IspitniRokId { get; set; }

        public OdjavaIspitaDTO()
        {

        }
    }
}