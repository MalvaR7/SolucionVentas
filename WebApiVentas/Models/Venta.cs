namespace WebApiVentas.Models
{
    public class Venta
    {
        public int Id { get; set; } 
        public DateTime Fecha { get; set; }   

        public Asesor AsesorVenta { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
        
    }
}
