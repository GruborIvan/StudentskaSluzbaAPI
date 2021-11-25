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
    public class StudentController : ApiController
    {
        IStudentRepository repo;

        public StudentController()
        {
            repo = new StudentRepository();
        }

        public IHttpActionResult Get(string brojIndeksa)
        {
            StudentDTO dto = repo.GetStudentByBrojIndeksa(brojIndeksa);
            dto.TokStudija = repo.GetUspehStudenta(brojIndeksa).ToList();
            return Ok(dto);
        }

    }
}
