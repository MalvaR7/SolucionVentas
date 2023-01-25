using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiVentas.Infraestructura;
using WebApiVentas.Models;
using WebApiVentas.Repository.Interfaces;

namespace WebApiVentas.Repository.Clases
{
    public class VentaRepository : IVentaRepository
    {
        public VentaRepository()
        {

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

        public Venta GetVenta(int id)
        {
            using (var context = new AplicacionDbContext())
            {
                var venta = context.Ventas.ToList().FirstOrDefault(a => a.Id == id);
                return venta;
            }
        }

        public bool Save(Venta venta)
        {
            using (var context = new AplicacionDbContext())
            {
                var result = context.Ventas.Where(a => a.Id == venta.Id);
                if (result != null)
                {
                    if (result.Count() == 0)
                    {
                        context.Ventas.Add(venta);
                        context.SaveChanges();
                        return true;
                    }
                }
            }            
            return false;
        }
        public bool Delete(int id)
        {
            using (var context = new AplicacionDbContext())
            {
                var venta = context.Ventas.Where(a => a.Id == id).First();
                if (venta != null)
                {
                    context.Ventas.Remove(venta);
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
          
        }
        public bool Update(Venta venta)
        {
            using (var context = new AplicacionDbContext())
            {
                var ventaux = context.Ventas.Where(a => a.Id == venta.Id).First();
                if (ventaux != null)
                {
                    ventaux.IdAsesor = venta.IdAsesor;
                    ventaux.DetalleVentas = venta.DetalleVentas;
                    ventaux.Fecha = venta.Fecha;
                    context.SaveChanges();
                    return true;
                }
            }
            return false;

        }
    }
}
