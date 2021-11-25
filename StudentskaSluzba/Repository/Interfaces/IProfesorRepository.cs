using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IProfesorRepository
    {
        IEnumerable<Profesor> GetProfesorForPredmet(int predmetId);
        Profesor GetProfesorByEmailAddress(string emailAddress);
        string GetZvanjeForProfesor(int profesorId);
    }
}
