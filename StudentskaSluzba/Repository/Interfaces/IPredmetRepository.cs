using StudentskaSluzba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IPredmetRepository
    {
        IEnumerable<Predmet> GetPredmetiForProfesor(string profesorId);
    }
}
