using WebApplication3.Entities;
using WebApplication3.Models;
using WebApplication3.MyPattern;

namespace WebApplication3.Service.StudentService
{
    public class StudentService : IStudentSerivce
    {
        private IStudentrepository _studentRepository;

        public StudentService(IStudentrepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string CreateStudent(StudentDTO studentDTO)
        {
            var result = _studentRepository.CreateStudent(studentDTO);

            return result;
        }

        public string DeleteStudent(int id)
        {
            var result = _studentRepository.DeleteStudent(id);
            return result;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var result = _studentRepository.GetAllStudents();
            return result;
        }

        public Student GetByIdStudent(int id)
        {
            var result = _studentRepository.GetByIdStudent(id);
            return result;
        }

        public string UpdateStudent(int id, StudentDTO studentDTO)
        {
            var result = _studentRepository.UpdateStudent(id, studentDTO);
            return result;
        }
    }
}
