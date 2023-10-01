using MVC_Project.Models.Entities.Classes;
using MVC_Project.Models.Entities.Enums;
using MVC_Project.Repositories.Abstracts;
using System.Linq.Expressions;

namespace MVC_Project.Services.LessonService
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepo _repo;

        public LessonService(ILessonRepo repo)
        {
            _repo = repo;
        }

        public void Create(Lesson entity)
        {
            _repo.Create(entity);
        }

        public void Delete(Lesson entity)
        {
            entity.DeleteDate = DateTime.Now;
            entity.Status = Status.Passive;
            _repo.Delete(entity);
        }

        public List<Lesson> GetAll()
        {
            return _repo.GetAll();
        }

        public Lesson GetDefault(Expression<Func<Lesson, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Lesson GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public List<Lesson> GetDefaults(Expression<Func<Lesson, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public void Update(Lesson entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.Status = Status.Modified;
            _repo.Update(entity);
        }
    }
}
