using AutoMapper;
using MVC_Project.Models.DTOs;
using MVC_Project.Models.Entities.Classes;
using MVC_Project.Models.VMs.SchoolVMs;

namespace MVC_Project.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<School,SchoolCreateVM>().ReverseMap();
            CreateMap<School, SchoolUpdateVM>().ReverseMap();
            CreateMap<School,SchoolListVM>().ReverseMap();
            CreateMap<School,SchoolDeleteDTO>().ReverseMap();
        }
    }
}
