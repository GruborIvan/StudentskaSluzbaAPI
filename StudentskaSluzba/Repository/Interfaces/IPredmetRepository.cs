using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IPredmetRepository
    {
        IEnumerable<PredmetiDTO2> GetPredmetiForProfesor(string profesorId);
    }
}
