namespace CRUDNativo.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string DocumentoIdentidad { get; set; }

        public string CorreoElectronico { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public ICollection<Venta> Ventas { get; set; }
    }
}
