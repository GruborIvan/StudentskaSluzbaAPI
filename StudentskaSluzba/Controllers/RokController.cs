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
    public class RokController : ApiController
    {
        IRokRepository repo;

        public RokController()
        {
            repo = new RokRepository();
        }

        public IEnumerable<IspitniRok> Get()
        {
            return repo.GetIspitniRokovi();
        }

        public IHttpActionResult Post([FromBody] IspitniRok rok)
        {
            repo.AddIspitniRok(rok);
            return Ok();
        }

    }
}
