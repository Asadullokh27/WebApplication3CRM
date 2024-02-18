
using WebApplication3.Models;
using WebApplication3.MyPattern;
using WebApplication3.Service.CourseService;
using WebApplication3.Service.StudentService;
using WebApplication3.Service.TeacherService;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IStudentrepository, Studentrepository>();
            builder.Services.AddScoped<ITeacherrepository, Teacherrepository>();
            builder.Services.AddScoped<ICourserepository, Courserepository>();


            builder.Services.AddScoped<IStudentSerivce, StudentService>();
            builder.Services.AddScoped<ITeacherService, TeacherService>();
            builder.Services.AddScoped<ICourseService, CourseService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
