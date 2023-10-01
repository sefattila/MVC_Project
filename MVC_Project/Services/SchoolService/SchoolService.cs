using MVC_Project.Models.Entities.Classes;
using MVC_Project.Models.Entities.Enums;
using MVC_Project.Repositories.Abstracts;
using System.Linq.Expressions;

namespace MVC_Project.Services.SchoolService
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepo _repo;

        public SchoolService(ISchoolRepo repo)
        {
            _repo = repo;
        }

        public void Create(School entity)
        {
            _repo.Create(entity);
        }

        public void Delete(School entity)
        {
            entity.DeleteDate = DateTime.Now;
            entity.Status = Status.Passive;
            _repo.Delete(entity);
        }

        public List<School> GetAll()
        {
            return _repo.GetAll();
        }

        public School GetDefault(Expression<Func<School, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public School GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public List<School> GetDefaults(Expression<Func<School, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public void Update(School entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.Status = Status.Modified;
            _repo.Update(entity);
        }
    }
}
