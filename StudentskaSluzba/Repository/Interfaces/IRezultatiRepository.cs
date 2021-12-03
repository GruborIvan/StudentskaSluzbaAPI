using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IRezultatiRepository
    {
        IEnumerable<PredmetiDTO> GetPolozeniPredmeti(string brojIndeksa,int mode, int ispitniRokId);
        void PostOcena(OcenaPostDTO dto);
    }
}
