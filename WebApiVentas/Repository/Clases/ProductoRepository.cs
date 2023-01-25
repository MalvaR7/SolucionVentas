using WebApiVentas.Infraestructura;
using WebApiVentas.Models;
using WebApiVentas.Repository.Interfaces;

namespace WebApiVentas.Repository.Clases
{
    public class ProductoRepository : IProductoRepository
    {
        public ProductoRepository()
        {
            using (var context = new AplicacionDbContext())
            {
                var productos = new List<Producto>
                {
                    new Producto { Nombre ="Producto A401", Precio= 200},
                    new Producto { Nombre ="Producto B206", Precio= 500}
                };

                context.Productos.AddRange(productos);
                context.SaveChanges();
            }
        }

        public Producto GetProducto(int id)
        {
            using (var context = new AplicacionDbContext())
            {
                var producto = context.Productos.ToList().FirstOrDefault(a => a.Id == id);
                return producto;
            }               
        }

        public List<Producto> GetProductos()
        {
            using (var context = new AplicacionDbContext())
            {
                var list = context.Productos
                    .ToList();
                return list;
            }
        }
        
    }
}
