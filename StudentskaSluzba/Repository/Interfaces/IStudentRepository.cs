using StudentskaSluzba.Models;
using StudentskaSluzba.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Repository.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetStudentsKojiSuPoloziliPredmet(int predmetId);
        IEnumerable<TokStudija> GetUspehStudenta(string brojIndeksa);
        StudentDTO GetStudentByBrojIndeksa(string brojIndeksa);
    }
}
