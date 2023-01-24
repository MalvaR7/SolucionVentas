using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiVentas.Models;
using WebApiVentas.Repository.Interfaces;

namespace WebApiVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        readonly IVentaRepository _ventaRepository;
        public VentaController(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }
        /*[HttpGet]
        public ActionResult<List<Venta>> Get()
        {
            return Ok(_ventaRepository.GetVentas());
        }*/

        [HttpGet]
        public ActionResult<List<Venta>> Get()
        {
            return null;
            //return Ok(_ventaRepository.GetVentas());
        }
    }
}
