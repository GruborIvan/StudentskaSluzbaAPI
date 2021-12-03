using StudentskaSluzba.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IIspitRepository
    {
        void PrijavaIspita(string studentId, int ispitId,int ispitniRokId);
        IEnumerable<PredmetiDTO2> GetPrijavljeniIspiti(string brojIndeksa);
    }
}
