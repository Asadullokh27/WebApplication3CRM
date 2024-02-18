using WebApplication3.Entities;
using WebApplication3.Models;
using WebApplication3.MyPattern;
using WebApplication3.Service.TeacherService;

namespace WebApplication3.Service.TeacherService
{
    public class TeacherService : ITeacherService
    {
        private ITeacherrepository _teacherRepository;

        public TeacherService(ITeacherrepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public string CreateTeacher(TeacherDTO teacher)
        {
            var result = _teacherRepository.CreateTeacher(teacher);

            return result;
        }

        public string DeleteTeacher(int id)
        {
            var result = _teacherRepository.DeleteTeacher(id);
            return result;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            IEnumerable<Teacher>? result = _teacherRepository.GetAllTeachers();
            return result;
        }

        public Teacher GetByIdTeacher(int id)
        {
            Teacher? result = _teacherRepository.GetByIdTeacher(id);
            return result;
        }

        public string UpdateTeacher(int id, TeacherDTO teacher)
        {
            var result = _teacherRepository.UpdateTeacher(id, teacher);
            return result;
        }
    }
}
