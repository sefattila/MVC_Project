﻿using MVC_Project.Models.Entities.Classes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.VMs.StudentVMs
{
    public class StudentListVM
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [Required]
        public string FullName { get; set; }
        [DisplayName("Class Name")]
        [Required]
        public string ClassName { get; set; }
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}
