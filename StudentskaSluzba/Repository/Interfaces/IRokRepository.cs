using StudentskaSluzba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IRokRepository
    {
        IEnumerable<IspitniRok> GetIspitniRokovi();
        void AddIspitniRok(IspitniRok rok);
        void FillIspitiForIspitniRok(DateTime startDate,DateTime endDate,int rokId);
    }
}
