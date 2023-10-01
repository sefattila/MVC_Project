using MVC_Project.Models.Entities.Abstracts;
using System.Linq.Expressions;

namespace MVC_Project.Repositories.Abstracts
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetDefault(Expression<Func<T, bool>> expression);
        List<T> GetDefaults(Expression<Func<T, bool>> expression);
        T GetDefaultById(int id);
        List<T> GetAll();
    }
}
