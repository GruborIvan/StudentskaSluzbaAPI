using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class OcenaPostDTO
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int PredmetId { get; set; }
        [Required]
        public int RokId { get; set; }
        [Required]
        public double PredispitniPoeni { get; set; }
        [Required]
        public double IspitniPoeni { get; set; }
    }
}