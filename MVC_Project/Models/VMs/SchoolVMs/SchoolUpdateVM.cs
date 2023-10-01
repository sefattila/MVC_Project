using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.VMs.SchoolVMs
{
    public class SchoolUpdateVM
    {
        public int Id { get; set; }
        [DisplayName("School Name")]
        [Required]
        public string Name { get; set; }
    }
}
