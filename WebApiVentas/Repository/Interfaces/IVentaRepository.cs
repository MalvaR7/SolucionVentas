using WebApiVentas.Models;

namespace WebApiVentas.Repository.Interfaces
{
    public interface IVentaRepository
    {
        public List<Venta> GetVentas();
        public bool Save(Venta venta);
        public bool Delete(int id);
        public Venta GetVenta(int id);
        public bool Update(Venta venta);
    }
}
