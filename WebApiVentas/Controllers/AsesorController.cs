using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiVentas.Models;
using WebApiVentas.Repository.Interfaces;

namespace WebApiVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]//Agregar seguridad a Web API
        public class AsesorController : ControllerBase
    {
        readonly IAsesorRepository _asesorRepository;
        public AsesorController(IAsesorRepository asesorRepository)
        {
            _asesorRepository = asesorRepository;
        }
        [HttpGet]
        [Route("GetAsesores")]
        public ActionResult<List<Asesor>> GetAsesores()
        {
          return Ok(_asesorRepository.GetAsesores());
        }
    }
}
