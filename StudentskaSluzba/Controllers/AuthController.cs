using StudentskaSluzba.Models.DTO;
using StudentskaSluzba.Repository.Interfaces;
using StudentskaSluzba.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentskaSluzba.Controllers
{
    public class AuthController : ApiController
    {
        IAuthRepository _repository;

        public AuthController()
        {
            _repository = new AuthRepository();
        }

        public IHttpActionResult Post(AuthDTO dto)
        {
            if (dto.IsStudent)
            {
                if (!_repository.StudentLogIn(dto.Username,dto.Password))
                {
                    return BadRequest();
                }
            }
            else
            {
                if (!_repository.ProfesorLogIn(dto.Username,dto.Password))
                {
                    return BadRequest();
                }
            }
            return Ok();
        }

    }
}
