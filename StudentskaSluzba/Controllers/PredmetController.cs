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
    public class PredmetController : ApiController
    {
        IPredmetRepository _repository;

        public PredmetController()
        {
            _repository = new PredmetRepository();
        }

        public IEnumerable<PredmetiDTO2> GetPredmetiForProfesor(string profesorId)
        {
            return _repository.GetPredmetiForProfesor(profesorId);
        }

    }
}
