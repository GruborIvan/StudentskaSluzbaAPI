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
    public class PdfController : ApiController
    {
        IFileRepository repo;

        public PdfController()
        {
            repo = new FileRepository();
        }

        public IHttpActionResult Get(int predmetId,int rokId)
        {
            repo.GeneratePDFDocument(predmetId,rokId);
            return Ok();
        }
    }
}
