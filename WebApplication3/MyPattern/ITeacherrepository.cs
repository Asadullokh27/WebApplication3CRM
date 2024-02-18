using WebApplication3.Entities;
using WebApplication3.Models;

namespace WebApplication3.MyPattern
{
    public interface ITeacherrepository
    {

        public string CreateTeacher(TeacherDTO teacherDTO);
        public IEnumerable<Teacher> GetAllTeachers();
        public Teacher GetByIdTeacher(int id);
        public string DeleteTeacher(int id);
        public string UpdateTeacher(int id, TeacherDTO teacherDTO);


    }
}
