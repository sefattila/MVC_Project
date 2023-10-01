using MVC_Project.Models.Entities.Abstracts;

namespace MVC_Project.Models.Entities.Classes
{
    public class Lesson:BaseEntity
    {
        public string Name { get; set; }
        public int Credit { get; set; }

        //nav prop  
        public virtual List<School>? Schools { get; set; }
        public virtual List<Student>? Students { get; set; }
    }
}
