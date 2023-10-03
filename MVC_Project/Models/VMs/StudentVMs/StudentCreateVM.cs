using MVC_Project.Models.Entities.Classes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.VMs.StudentVMs
{
    public class StudentCreateVM
    {
        public StudentCreateVM()
        {
            Schools=new List<School>();
        }
        [DisplayName("Full Name")]
        [Required]
        public string FullName { get; set; }
        [DisplayName("Class Name")]
        [Required]
        public string ClassName { get; set; }
        [DisplayName("School Name")]
        [Required]
        public int SchoolId { get; set; }
        public IList<School> Schools { get; set; }
    }
}
