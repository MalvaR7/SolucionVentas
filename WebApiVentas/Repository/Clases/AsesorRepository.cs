using Microsoft.EntityFrameworkCore;
using WebApiVentas.Infraestructura;
using WebApiVentas.Models;
using WebApiVentas.Repository.Interfaces;

namespace WebApiVentas.Repository.Clases
{
    public class AsesorRepository : IAsesorRepository
    {
        public AsesorRepository() {

            using (var context = new AplicacionDbContext())
            {
                var asesores = new List<Asesor>
                {
                    new Asesor { Nombre ="Daniel", Apellido= "Huerta"},
                    new Asesor { Nombre ="Liliana", Apellido= "Torres"}
                };               
             
                context.Asesores.AddRange(asesores);
                context.SaveChanges();
            }
        }
    
        public List<Asesor> GetAsesores()
        {
            using (var context = new AplicacionDbContext())
            {
                var list = context.Asesores                    
                    .ToList();
                return list;
            }
        }       
    }
}
