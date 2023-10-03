using AutoMapper;
using MVC_Project.Models.DTOs;
using MVC_Project.Models.Entities.Classes;
using MVC_Project.Models.VMs.LessonVMs;
using MVC_Project.Models.VMs.SchoolVMs;
using MVC_Project.Models.VMs.StudentVMs;

namespace MVC_Project.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<School, SchoolCreateVM>().ReverseMap();
            CreateMap<School, SchoolUpdateVM>().ReverseMap();
            CreateMap<School, SchoolListVM>().ReverseMap();
            CreateMap<School, SchoolDeleteDTO>().ReverseMap();

            CreateMap<Lesson, LessonCreateVM>().ReverseMap();
            CreateMap<Lesson, LessonUpdateVM>().ReverseMap();

            CreateMap<Student, StudentCreateVM>().ForMember(dest => dest.Schools, opt => opt.Ignore()).ReverseMap();
            CreateMap<Student, StudentUpdateVM>().ForMember(dest => dest.Schools, opt => opt.Ignore()).ReverseMap();
            CreateMap<Student, StudentListVM>().ReverseMap();

        }
    }
}
