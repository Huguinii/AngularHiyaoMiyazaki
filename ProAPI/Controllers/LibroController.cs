
using ApiPelicula.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using RestAPI.Controllers.RestAPI.Controllers;
using RestAPI.Models.DTOs.DibujoDTO;
using RestAPI.Models.Entity;
using System.Diagnostics;

namespace ProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : BaseController<DibujoEntity, DibujoDTO, CreateDibujoDTO>
    {
        public LibroController(IDibujoRepository DibujoRepository,
            IMapper mapper, ILogger<DibujoController> logger)
            : base(DibujoRepository, mapper, logger)
        {

        }
    }
}
