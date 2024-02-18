using WebApplication3.Entities;
using WebApplication3.Models;

namespace WebApplication3.Service.CourseService
{
    public interface ICourseService
    {
        public string CreateCourse(CourseDTO courseDTO);
        public IEnumerable<Course> GetAllCourses();
        public Course GetByIdCourse(int id);
        public string DeleteCourse(int id);
        public string UpdateCourse(int id, CourseDTO courseDTO);
    }
}
