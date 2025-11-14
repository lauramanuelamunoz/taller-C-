using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class EmpleadoTiktok
    {
        public string Nombre { get; set; }
        public int AnioNacimiento { get; set; }
        public int MesNacimiento { get; set; }

        public int CalcularEdad(int anioActual)
        {
            return anioActual - AnioNacimiento;
        }
    }
}
