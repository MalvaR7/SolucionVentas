using WebApiVentas.Models;

namespace WebApiVentas.Repository.Interfaces
{
    public interface IProductoRepository
    {
        public List<Producto> GetProductos();
    }
}
