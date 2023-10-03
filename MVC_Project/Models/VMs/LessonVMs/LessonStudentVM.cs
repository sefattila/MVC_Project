using MVC_Project.Models.Entities.Classes;

namespace MVC_Project.Models.VMs.LessonVMs
{
    public class LessonStudentVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ClassName { get; set; }
        public List<Student> StudentTakingLesson { get; set; }
        public List<Student> StudentNotTakingLesson { get; set; }
    }
}
