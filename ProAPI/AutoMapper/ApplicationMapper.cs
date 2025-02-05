using ProAPI.Models.DTOs.DibujoDTO;
using ProAPI.Models.DTOs.UserDto;
using AutoMapper;
using ProAPI.Models.Entity;
using RestAPI.Repository;
using ProAPI.Repository;
using ProAPI.Models.DTOs.CategoryDto;

namespace ProAPI.AutoMapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<DibujoDTO, DibujoEntity>().ReverseMap();
            CreateMap<CategoryDto, CategoryRepository>().ReverseMap();
            CreateMap<AppUser, UserDto>().ReverseMap();
        }
    }
}
