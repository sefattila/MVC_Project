using MVC_Project.Context;
using MVC_Project.Models.Entities.Classes;
using MVC_Project.Repositories.Abstracts;

namespace MVC_Project.Repositories.Concretes
{
    public class LessonRepo : BaseRepo<Lesson>, ILessonRepo
    {
        public LessonRepo(AppDbContext context) : base(context)
        {
        }
    }
}
