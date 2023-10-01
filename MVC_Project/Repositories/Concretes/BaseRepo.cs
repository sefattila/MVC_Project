using Microsoft.EntityFrameworkCore;
using MVC_Project.Context;
using MVC_Project.Models.Entities.Abstracts;
using MVC_Project.Models.Entities.Enums;
using MVC_Project.Repositories.Abstracts;
using System.Linq.Expressions;

namespace MVC_Project.Repositories.Concretes
{
    public class BaseRepo<T>:IBaseRepo<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public BaseRepo(AppDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public void Create(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _table.Where(x=>x.Status!= Status.Passive).ToList();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.FirstOrDefault(expression);
        }

        public T GetDefaultById(int id)
        {
            return _table.Find(id);
        }

        public List<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
