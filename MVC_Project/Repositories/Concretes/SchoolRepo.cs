using MVC_Project.Context;
using MVC_Project.Models.Entities.Classes;
using MVC_Project.Repositories.Abstracts;

namespace MVC_Project.Repositories.Concretes
{
    public class SchoolRepo : BaseRepo<School>, ISchoolRepo
    {
        public SchoolRepo(AppDbContext context) : base(context)
        {
        }
    }
}
