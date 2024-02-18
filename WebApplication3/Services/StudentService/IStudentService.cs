using WebApplication3.Entities;
using WebApplication3.Models;

namespace WebApplication3.Service.StudentService
{
    public interface IStudentSerivce
    {
        public string CreateStudent(StudentDTO studentDTO);
        public IEnumerable<Student> GetAllStudents();
        public Student GetByIdStudent(int id);
        public string DeleteStudent(int id);
        public string UpdateStudent(int id, StudentDTO studentDTO);
    }
}