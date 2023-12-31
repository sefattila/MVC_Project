﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models.VMs.LessonVMs
{
    public class LessonUpdateVM
    {
        public int Id { get; set; }
        [DisplayName("Lesson Name")]
        [Required]
        public string Name { get; set; }
        [DisplayName("AKTS")]
        [Required]
        public int Credit { get; set; }
    }
}
