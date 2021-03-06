using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using StudentskaSluzba.Repository.Interfaces;
using StudentskaSluzba.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentskaSluzba.Controllers
{
    public class ProfesorController : ApiController
    {
        IProfesorRepository repo;
        IRezultatiRepository repo2;

        public ProfesorController()
        {
            repo = new ProfesorRepository();
            repo2 = new RezultatiRepository();
        }

        public IEnumerable<StudentDTO2> GetStudentZaOcenjivanje(int predmetId,int rokId)
        {
            return repo.GetStudentiZaOcenjivanje(predmetId,rokId);
        }

        public IHttpActionResult Get(string emailAddress)
        {
            Profesor p = repo.GetProfesorByEmailAddress(emailAddress);
            ProfesorDTO dto = new ProfesorDTO(p.Id, p.Ime, p.Prezime, p.Citiranost, p.Email, p.Password);
            dto.Zvanje = repo.GetZvanjeForProfesor(p.Id);
            dto.Zvanja = p.Zvanja.OrderByDescending(x => x.DatumDobijanjaZvanja).ToList();
            foreach (ZvanjeProfesora zp in dto.Zvanja)
            {
                zp.Profesori = null;
            }
            return Ok(dto);
        }

        public IHttpActionResult Post(OcenaPostDTO postDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            repo2.PostOcena(postDto);
            return Ok();
        }

    }
}
