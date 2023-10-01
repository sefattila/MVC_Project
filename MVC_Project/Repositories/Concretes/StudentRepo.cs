using MVC_Project.Context;
using MVC_Project.Models.Entities.Abstracts;
using MVC_Project.Models.Entities.Classes;
using MVC_Project.Repositories.Abstracts;

namespace MVC_Project.Repositories.Concretes
{
    public class StudentRepo : BaseRepo<Student>, IStudentRepo
    {
        public StudentRepo(AppDbContext context) : base(context)
        {
        }
    }
}
