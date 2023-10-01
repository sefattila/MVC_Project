using MVC_Project.Models.Entities.Classes;
using MVC_Project.Models.Entities.Enums;
using MVC_Project.Repositories.Abstracts;
using System.Linq.Expressions;

namespace MVC_Project.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _repo;

        public StudentService(IStudentRepo repo)
        {
            _repo = repo;
        }

        public void Create(Student entity)
        {
            _repo.Create(entity);
        }

        public void Delete(Student entity)
        {
            entity.DeleteDate=DateTime.Now;
            entity.Status = Status.Passive;
            _repo.Delete(entity);
        }

        public List<Student> GetAll()
        {
            return _repo.GetAll();
        }

        public Student GetDefault(Expression<Func<Student, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Student GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public List<Student> GetDefaults(Expression<Func<Student, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public void Update(Student entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.Status = Status.Modified;
            _repo.Update(entity);
        }
    }
}
