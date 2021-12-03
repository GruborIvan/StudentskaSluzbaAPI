using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class PrijavaIspitaPostDTO
    {
        [Required]
        public string BrojIndeksa { get; set; }
        [Required]
        public int IspitId { get; set; }
        [Required]
        public int IspitniRokId { get; set; }
    }
}