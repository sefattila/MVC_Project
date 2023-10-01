using MVC_Project.Models.Entities.Classes;
using System.Linq.Expressions;

namespace MVC_Project.Services.SchoolService
{
    public interface ISchoolService
    {
        void Create(School entity);
        void Update(School entity);
        void Delete(School entity);
        School GetDefault(Expression<Func<School, bool>> expression);
        List<School> GetDefaults(Expression<Func<School, bool>> expression);
        School GetDefaultById(int id);
        List<School> GetAll();
    }
}
