using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class ProfesorDTO
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Citiranost { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Zvanje { get; set; }
        public List<ZvanjeProfesora> Zvanja { get; set; }

        public ProfesorDTO()
        {

        }

        public ProfesorDTO(int id, string ime, string prezime, int citiranost, string email, string password)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Citiranost = citiranost;
            Email = email;
            Password = password;
        }
    }
}