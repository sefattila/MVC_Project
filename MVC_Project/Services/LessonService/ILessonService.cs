using MVC_Project.Models.Entities.Classes;
using System.Linq.Expressions;

namespace MVC_Project.Services.LessonService
{
    public interface ILessonService
    {
        void Create(Lesson entity);
        void Update(Lesson entity);
        void Delete(Lesson entity);
        Lesson GetDefault(Expression<Func<Lesson, bool>> expression);
        List<Lesson> GetDefaults(Expression<Func<Lesson, bool>> expression);
        Lesson GetDefaultById(int id);
        List<Lesson> GetAll();
    }
}
