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
    public class IspitController : ApiController
    {
        IIspitRepository repo;

        public IspitController()
        {
            repo = new IspitRepository();
        }

        public IEnumerable<PredmetiDTO2> Get(string brojIndeksa)
        {
            return repo.GetPrijavljeniIspiti(brojIndeksa);
        }

        public IHttpActionResult Post([FromBody] PrijavaIspitaPostDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            repo.PrijavaIspita(dto.BrojIndeksa, dto.IspitId,dto.IspitniRokId);
            return Ok();
        }

    }
}
