﻿namespace WebApiVentas.Models
{
    public class DetalleVenta
    {
       public int Id { get; set; }      
       public Producto Producto { get; set; } 
       public int Cantidad { get; set; }       

    }
}
