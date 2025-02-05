using ProAPI.Models.DTOs.CategoryDto;
using ProAPI.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ProAPI.Models.Entity;
using System.Diagnostics;
using ProAPI.Controllers.ProAPI.Controllers;
using RestAPI.Repository.IRepository;

namespace ProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController<Category, CategoryDto, CreateCategoryDto>
    {
        public CategoryController(ICategoryRepository categoryRepository,
            IMapper mapper, ILogger<CategoryController> logger)
            : base(categoryRepository, mapper, logger)
        {

        }
    }
}
