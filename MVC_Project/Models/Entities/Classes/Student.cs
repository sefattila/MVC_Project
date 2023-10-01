using MVC_Project.Models.Entities.Abstracts;

namespace MVC_Project.Models.Entities.Classes
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; }
        public string ClassName { get; set; } //9-D
        public int SchoolId { get; set; }

        //Nav Prop
        public virtual School School { get; set; }
        public virtual List<Lesson>? Lessons { get; set; }
    }
}
