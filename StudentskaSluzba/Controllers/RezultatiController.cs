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

        public RezultatiController()
        {
            repo = new RezultatiRepository();
        }

        public IEnumerable<PredmetiDTO> Get(string brIndeksa,int mode,int ispitniRokId)
        {
            return repo.GetPolozeniPredmeti(brIndeksa,mode,ispitniRokId);
        }

    }
}
