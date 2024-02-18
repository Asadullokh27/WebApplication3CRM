using Microsoft.AspNetCore.Cors.Infrastructure;
using WebApplication3.Entities;
using WebApplication3.Models;
using WebApplication3.MyPattern;

namespace WebApplication3.Service.CourseService
{
    public class CourseService : ICourseService
    {
        private ICourserepository _courseRepository;

        public CourseService(ICourserepository course)
        {
            _courseRepository = course;
        }
        public string CreateCourse(CourseDTO courseDTO)
        {
            var result = _courseRepository.CreateCourse(courseDTO);
            return result;
        }

        public string DeleteCourse(int id)
        {
            var result = _courseRepository.DeleteCourse(id);
            return result;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            var result = _courseRepository.GetAllCourses();
            return result;
        }

        public Course GetByIdCourse(int id)
        {
            var result = _courseRepository.GetByIdCourse(id);
            return result;
        }
        public string UpdateCourse(int id, CourseDTO courseDTO)
        {
            var result = _courseRepository.UpdateCourse(id, courseDTO);
            return result;
        }
    }
}
