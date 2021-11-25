using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class AuthDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsStudent { get; set; }
    }
}