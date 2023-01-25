using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using WebVentas.Models;

namespace WebVentas.Controllers
{
    public class ProductosController : Controller
    {
        Producto _oProducto = new Producto();
        List<Producto> _oProductos = new List<Producto>();
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<List<Producto>> GetProductos()
        {
            _oProductos = new List<Producto>();

            using (var httpClient = new HttpClient())
            {
               
				/*httpClient.DefaultRequestHeaders.Authorization
						 = new AuthenticationHeaderValue("Bearer", token);*/
				using (var response = await httpClient.GetAsync("http://localhost:5014/api/Producto/GetProductos"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _oProductos = JsonConvert.DeserializeObject<List<Producto>>(apiResponse);
                }

            }
            return _oProductos;
        }       
    }
}
