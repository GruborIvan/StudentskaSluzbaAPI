using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IFileRepository
    {
        void GeneratePDFDocument(int predmetId, int rokId);
    }
}
