using MVC_Project.Models.Entities.Abstracts;

namespace MVC_Project.Models.Entities.Classes
{
    public class Lesson:BaseEntity
    {
        public string Name { get; set; }
        public int Credit { get; set; }

        //nav prop  
        public virtual IList<School>? Schools { get; set; }
        public virtual IList<Student>? Students { get; set; }
    }
}
