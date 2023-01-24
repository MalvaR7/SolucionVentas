using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiVentas.Models;


namespace WebApiVentas.Infraestructura
{
    public class AplicacionDbContext : DbContext
    {
       protected override void OnConfiguring
 (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "VentasDb");
        }
        public AplicacionDbContext()
        {

        }
        /*public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options)
            : base(options)
        {

        }*/

        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Asesor> Asesores { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
    /*public class ApiContext : DbContext
    {
        protected override void OnConfiguring
      (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "VentasDb");
        }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Asesor> Asesores { get; set; }        
        public DbSet<Producto> Productos { get; set; }

    }
    */
}
