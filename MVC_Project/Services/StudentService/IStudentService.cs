using MVC_Project.Models.Entities.Classes;
using System.Linq.Expressions;

namespace MVC_Project.Services.StudentService
{
    public interface IStudentService
    {
        void Create(Student entity);
        void Update(Student entity);
        void Delete(Student entity);
        Student GetDefault(Expression<Func<Student, bool>> expression);
        List<Student> GetDefaults(Expression<Func<Student, bool>> expression);
        Student GetDefaultById(int id);
        List<Student> GetAll();
    }
}
