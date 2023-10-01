using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.VMs.SchoolVMs
{
    public class SchoolCreateVM
    {
        [DisplayName("School Name")]
        [Required]
        public string Name { get; set; }
    }
}
