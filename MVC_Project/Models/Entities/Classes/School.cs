using MVC_Project.Models.Entities.Abstracts;

namespace MVC_Project.Models.Entities.Classes
{
    public class School:BaseEntity
    {
        public string Name { get; set; }
        //Nav Prop
        public virtual List<Lesson>? Lessons { get; set; }
        public virtual List<Student>? Students { get; set; }
    }
}
