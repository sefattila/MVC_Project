using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models.DTOs;
using MVC_Project.Models.Entities.Classes;
using MVC_Project.Models.VMs.LessonVMs;
using MVC_Project.Models.VMs.SchoolVMs;
using MVC_Project.Services.LessonService;
using MVC_Project.Services.SchoolService;
using MVC_Project.Services.StudentService;

namespace MVC_Project.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILessonService _lessonService;
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public LessonController(ILessonService lessonService, IMapper mapper, IStudentService studentService)
        {
            _lessonService = lessonService;
            _mapper = mapper;
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            return View(_lessonService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LessonCreateVM lessonCreateVM)
        {
            if (ModelState.IsValid)
            {
                var lesson = _mapper.Map<Lesson>(lessonCreateVM);
                _lessonService.Create(lesson);
                return RedirectToAction("Index");
            }
            return View(lessonCreateVM);
        }

        public IActionResult Update(int id)
        {
            var lesson = _lessonService.GetDefaultById(id);
            var lessonVM = _mapper.Map<LessonUpdateVM>(lesson);
            return View(lessonVM);
        }
        [HttpPost]
        public IActionResult Update(LessonUpdateVM lessonUpdateVM)
        {
            if (ModelState.IsValid)
            {
                var lesson = _mapper.Map<Lesson>(lessonUpdateVM);
                _lessonService.Update(lesson);
                return RedirectToAction("Index");
            }
            return View(lessonUpdateVM);
        }
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _lessonService.Delete(_lessonService.GetDefaultById(id));
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult AddStudent(int id)
        {
            var taking=_studentService.GetAll().Where(x=>x.Lessons.Any(x=>x.Id == id)).ToList();
            var notTaking=_studentService.GetAll().Where(x=>x.Lessons.All(x=>x.Id != id)).ToList();

            LessonStudentVM lessonStudentVM=new LessonStudentVM();
            lessonStudentVM.StudentTakingLesson = taking;
            lessonStudentVM.StudentNotTakingLesson=notTaking;
            return View(lessonStudentVM);
        }
    }
}
