using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class PasswordChangeDTO
    {
        public string OsobaId { get; set; }
        public string OsobaType { get; set; }
        public string Password { get; set; }

        public PasswordChangeDTO()
        {

        }
    }
}