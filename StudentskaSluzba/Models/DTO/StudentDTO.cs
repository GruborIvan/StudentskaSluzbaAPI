using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Models.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Password { get; set; }
        public int AdresaId { get; set; }
        public Adresa Adresa { get; set; }
        public List<TokStudija> TokStudija { get; set; }

        public StudentDTO(int id, string ime, string prezime, string brojIndeksa, string password, int adresaId)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            BrojIndeksa = brojIndeksa;
            Password = password;
            AdresaId = adresaId;
        }
    }
}