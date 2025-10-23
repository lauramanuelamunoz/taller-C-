using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public ProgramaAcademico Programa { get; set; }
        public string MetodoPago { get; set; } 

        public Estudiante(string nombre, ProgramaAcademico programa, string metodoPago)
        {
            Nombre = nombre;
            Programa = programa;
            MetodoPago = metodoPago;
        }
    }
}
