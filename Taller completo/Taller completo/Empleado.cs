using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public double Venta { get; set; }
        public double Bonificacion { get; set; }
        public double PagoTotal { get; set; }

        public Empleado(string nombre, double venta)
        {
            Nombre = nombre;
            Venta = venta;
            Bonificacion = 0;
            PagoTotal = 0;
        }
    }
}
