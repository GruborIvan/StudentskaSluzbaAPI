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
    public class RezultatiController : ApiController
    {
        IRezultatiRepository repo;
        IIspitRepository repo2;

        public RezultatiController()
        {
            repo = new RezultatiRepository();
            repo2 = new IspitRepository();
        }

        public IEnumerable<PredmetiDTO> Get(string brIndeksa,int mode,int ispitniRokId)
        {
            return repo.GetPolozeniPredmeti(brIndeksa,mode,ispitniRokId);
        }

        public IHttpActionResult Post([FromBody] OdjavaIspitaDTO odjavaPayload)
        {
            bool result = repo2.OdjavaIspita(odjavaPayload.BrojIndeksa, odjavaPayload.PredmetId, odjavaPayload.IspitniRokId);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

    }
}
