using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_modificadores_de_acceso
{
    public class LibroDigital : Libro
    {
        private double tamañoArchivoMB;

        public LibroDigital(string titulo, string autor, int paginasIniciales, double tamañoArchivoMB)
            : base(titulo, autor, paginasIniciales)
        {
            this.tamañoArchivoMB = tamañoArchivoMB;
        }

        public void MostrarResumenDigital()
        {
            string resumenBase = GenerarResumen();
            Console.WriteLine($"{resumenBase} Tamaño del archivo: {tamañoArchivoMB:F2} MB.");
        }
    }
}