using MVC_Project.Models.Entities.Abstracts;

namespace MVC_Project.Models.Entities.Classes
{
    public class School:BaseEntity
    {
        public string Name { get; set; }
        //Nav Prop
        public virtual IList<Lesson>? Lessons { get; set; }
        public virtual IList<Student>? Students { get; set; }
    }
}
