namespace CRUDNativo.Models
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
