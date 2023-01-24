using WebApiVentas.Models;

namespace WebApiVentas.Repository.Interfaces
{
    public interface IVentaRepository
    {
        public List<Venta> GetVentas();   
    }
}
