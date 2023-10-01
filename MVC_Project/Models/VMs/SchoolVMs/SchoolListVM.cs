using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.VMs.SchoolVMs
{
    public class SchoolListVM
    {
        public int Id { get; set; }
        [DisplayName("School Name")]
        public string Name { get; set; }
    }
}
