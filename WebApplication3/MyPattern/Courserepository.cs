﻿using Dapper;
using Npgsql;
using WebApplication3.Entities;
using WebApplication3.Models;

namespace WebApplication3.MyPattern
{
    public class Courserepository : ICourserepository
    {

        public IConfiguration _configuration;

        public Courserepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CreateCourse(Entities.CourseDTO courseDTO)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("Postgres")))
            {
                var query = "INSERT INTO course (course_name, teacher_id, duration, price, description, students_count) VALUES (@course_name, @teacher_id, @duration, @price, @description, @students_count)";

                var data = new Entities.CourseDTO
                {
                    course_name = courseDTO.course_name,
                    teacher_id = courseDTO.teacher_id,
                    duration = courseDTO.duration,
                    price = courseDTO.price,
                    description = courseDTO.description,
                    students_count = courseDTO.students_count,
                };

                var result = connection.Query(query, data);
                return $"ok {result}";
            }
        }

        public string DeleteCourse(int id)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("Postgres")))
            {
                var query = "DELETE FROM course WHERE id = @id";
                connection.Query(query, new { id });

                return "ok";
            }
        }

        public IEnumerable<Course> GetAllCourses()
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("Postgres")))
            {
                var query = "SELECT * FROM course";
                var results = connection.Query<Course>(query);

                return results;
            }
        }

        public Course GetByIdCourse(int id)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("Postgres")))
            {
                var query = "SELECT * FROM course WHERE id = @id";
                var result = connection.QueryFirstOrDefault<Course>(query, new { id });

                return result!;
            }
        }

        public string UpdateCourse(int id, CourseDTO courseDTO)
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("Postgres")))
            {
                var query = "UPDATE course SET name = @name, description = @description, price = @price WHERE id = @id";
                var result = connection.Query(query, courseDTO);

                return "ok";
            }
        }

    }
}
