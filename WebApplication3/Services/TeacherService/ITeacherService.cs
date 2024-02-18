using WebApplication3.Entities;
using WebApplication3.Models;

namespace WebApplication3.Service.TeacherService
{
    public interface ITeacherService
    {
        public IEnumerable<Teacher> GetAllTeachers();
        public Teacher GetByIdTeacher(int id);
        public string CreateTeacher(TeacherDTO teacher);
        public string UpdateTeacher(int id, TeacherDTO teacher);
        public string DeleteTeacher(int id);
    }
}