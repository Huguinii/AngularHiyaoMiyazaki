using ProAPI.Models.DTOs.CategoryDto;
using ProAPI.Models.DTOs.UserDto;
using AutoMapper;
using ProAPI.Models.DTOs;
using ProAPI.Models.DTOs.LibroDTO;
using ProAPI.Models.Entity;

namespace ProAPI.AutoMapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<LibroEntity, LibroDTO>().ReverseMap();
            CreateMap<LibroEntity, CreateLibroDTO>().ReverseMap();
            CreateMap<EditorialEntity, EditorialDTO>().ReverseMap();
            CreateMap<EditorialEntity, CreateEditorialDTO>().ReverseMap();
            CreateMap<SovietTankEntity, SovietTankDTO>().ReverseMap();
            CreateMap<CreateSovietTankDTO, SovietTankEntity>().ReverseMap();
            CreateMap<DibujoDTO, >
            CreateMap<AppUser, UserDto>().ReverseMap();
        }
    }
}
