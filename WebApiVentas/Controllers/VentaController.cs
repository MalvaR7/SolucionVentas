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
  
        [HttpGet]
        [Route("GetVentas")]
        public ActionResult<List<Venta>> GetVentas()
        {
             return Ok(_ventaRepository.GetVentas());
        }

        [HttpGet]
        [Route("GetVenta")]
        public ActionResult<Venta> GetVenta(int id)
        {
            return Ok(_ventaRepository.GetVenta(id));
        }
        [HttpPost]        
        [Route("Insert")]
        public IActionResult Insert([FromBody] Venta venta)
        {
            if (ModelState.IsValid)
            {                
                return Ok(_ventaRepository.Save(venta));
            }
            return BadRequest(ModelState);
        }
        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_ventaRepository.Delete(id));           
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] Venta venta)
        {           
            return Ok(_ventaRepository.Update(venta));
        }
    }
}
