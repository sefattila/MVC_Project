using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC_Project.Models.DTOs;
using MVC_Project.Models.Entities.Classes;
using MVC_Project.Models.VMs.SchoolVMs;
using MVC_Project.Repositories.Abstracts;
using MVC_Project.Services.SchoolService;

namespace MVC_Project.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolService _schoolService;
        private readonly IMapper _mapper;

        public SchoolController(ISchoolService schoolService, IMapper mapper)
        {
            _schoolService = schoolService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var schools = _schoolService.GetAll().Select(x=>_mapper.Map<SchoolListVM>(x)).ToList();
            return View(schools);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SchoolCreateVM schoolCreateVM)
        {
            if(ModelState.IsValid)
            {
                var school = _mapper.Map<School>(schoolCreateVM);
                _schoolService.Create(school);
                return RedirectToAction("Index");
            }
            return View(schoolCreateVM);
        }

        public IActionResult Update(int id)
        {
            var school = _schoolService.GetDefaultById(id);
            var schoolVM=_mapper.Map<SchoolUpdateVM>(school);
            return View(schoolVM);
        }
        [HttpPost]
        public IActionResult Update(SchoolUpdateVM schoolUpdateVM)
        {
            if(ModelState.IsValid)
            {
                var school = _mapper.Map<School>(schoolUpdateVM);
                _schoolService.Update(school); 
                return RedirectToAction("Index");
            }
            return View(schoolUpdateVM);
        }
        public IActionResult Delete(SchoolDeleteDTO schoolDeleteDTO)
        {
            var schoolDelete=_schoolService.GetDefaultById(schoolDeleteDTO.Id);
            if (ModelState.IsValid)
            {
                var school = _mapper.Map<School>(schoolDelete);
                _schoolService.Delete(school);
                return RedirectToAction("Index");
            }
            return View(schoolDeleteDTO);
        }
    }
}
