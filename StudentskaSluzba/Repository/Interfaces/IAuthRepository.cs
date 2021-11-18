using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IAuthRepository
    {
        bool StudentLogIn(string brojIndeksa,string password);
        bool ProfesorLogIn(string email, string password);
    }
}
