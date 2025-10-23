using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class Conductor
    {
        public int AnioNacimiento { get; set; }
        public int Sexo { get; set; }    
        public int Registro { get; set; }  

        public int CalcularEdad(int anioActual)
        {
            return anioActual - AnioNacimiento;
        }
    }
}
