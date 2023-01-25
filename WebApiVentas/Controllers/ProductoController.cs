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
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]//Agregar seguridad a Web API
    public class ProductoController : ControllerBase
    {
        readonly IProductoRepository _productoRepository;
        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        [HttpGet]
        [Route("GetProductos")]
        public ActionResult<List<Producto>> GetProductos()
        {
            return Ok(_productoRepository.GetProductos());
        }
    }
}
