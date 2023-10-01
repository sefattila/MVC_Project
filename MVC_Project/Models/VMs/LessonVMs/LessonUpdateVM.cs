using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.VMs.LessonVMs
{
    public class LessonUpdateVM
    {
        [DisplayName("Lesson Name")]
        [Required]
        public string Name { get; set; }
        [DisplayName("AKTS")]
        [Required]
        public int Credit { get; set; }
    }
}
