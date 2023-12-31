﻿using MVC_Project.Models.Entities.Classes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.VMs.StudentVMs
{
    public class StudentUpdateVM
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [Required]
        public string FullName { get; set; }
        [DisplayName("Class Name")]
        [Required]
        public string ClassName { get; set; }
        [DisplayName("School Name")]
        [Required]
        public int SchoolId { get; set; }
        [DisplayName("School Name")]
        public IList<School> Schools { get; set; }
    }
}
