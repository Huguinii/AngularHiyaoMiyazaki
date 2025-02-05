
using ProAPI.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ProAPI.Controllers;
using ProAPI.Models.DTOs;
using ProAPI.Models.Entity;
using System.Diagnostics;
using ProAPI.Controllers.ProAPI.Controllers;
using ProAPI.Models.DTOs.DibujoDTO;

namespace ProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DibujoController : BaseController<DibujoEntity, DibujoDTO, CreateDibujoDTO>
    {
        public DibujoController(IDibujoRepository DibujoRepository,
            IMapper mapper, ILogger<DibujoController> logger)
            : base(DibujoRepository, mapper, logger)
        {

        }
    }
}
