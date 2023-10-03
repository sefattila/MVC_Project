using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models.Entities.Classes;
using MVC_Project.Models.VMs.LessonVMs;
using MVC_Project.Models.VMs.StudentVMs;
using MVC_Project.Services.LessonService;
using MVC_Project.Services.SchoolService;
using MVC_Project.Services.StudentService;

namespace MVC_Project.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ISchoolService _schoolService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper, ISchoolService schoolService)
        {
            _studentService = studentService;
            _mapper = mapper;
            _schoolService = schoolService;
        }

        public IActionResult Index()
        {
            var student = _studentService.GetAll().Select(x => _mapper.Map<StudentListVM>(x));
            return View(student);
        }
        public IActionResult Create()
        {
            StudentCreateVM studentCreateVM= new StudentCreateVM(); 
            studentCreateVM.Schools = _schoolService.GetAll();
            return View(studentCreateVM);
        }
        [HttpPost]
        public IActionResult Create(StudentCreateVM studentCreateVM)
        {
            if (ModelState.IsValid)
            {
                var student = _mapper.Map<Student>(studentCreateVM);
                _studentService.Create(student);
                return RedirectToAction("Index");
            }
            return View(studentCreateVM);
        }

        public IActionResult Update(int id)
        {
            var student = _studentService.GetDefaultById(id);
            var studentVM = _mapper.Map<StudentUpdateVM>(student);
            studentVM.Schools=_schoolService.GetAll();
            return View(studentVM);
        }
        [HttpPost]
        public IActionResult Update(StudentUpdateVM studentUpdateVM)
        {
            if (ModelState.IsValid)
            {
                var student = _mapper.Map<Student>(studentUpdateVM);
                _studentService.Update(student);
                return RedirectToAction("Index");
            }
            return View(studentUpdateVM);
        }
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _studentService.Delete(_studentService.GetDefaultById(id));
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
