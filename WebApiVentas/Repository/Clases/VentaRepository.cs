using Microsoft.EntityFrameworkCore;
using WebApiVentas.Infraestructura;
using WebApiVentas.Models;
using WebApiVentas.Repository.Interfaces;

namespace WebApiVentas.Repository.Clases
{
    public class VentaRepository : IVentaRepository
    {
        public VentaRepository() {

        }

        public List<Venta> GetVentas()
        {

            using (var context = new AplicacionDbContext())
            {
                var list = context.Ventas
                    .Include(a => a.DetalleVentas)
                    .ToList();
                return list;
            }
        }
    }
}
