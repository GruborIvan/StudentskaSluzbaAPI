using StudentskaSluzba.Models;
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
    public class StudentInfoController : ApiController
    {
        IStudentRepository repo;

        public StudentInfoController()
        {
            repo = new StudentRepository();
        }

        public IEnumerable<TokStudija> Get(string brojIndeksa)
        {
            return repo.GetUspehStudenta(brojIndeksa);
        }

    }
}
