using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_modificadores_de_acceso
{
    public class Camion : Vehiculo
    {
        public Camion(string marca, string modelo, double kilometrajeInicial)
            : base(marca, modelo, kilometrajeInicial)
        {
        }

        public void MostrarCostoMantenimiento()
        {
            double costoCalculado = CalcularCostoMantenimiento();
            Console.WriteLine($"Costo de mantenimiento estimado: ${costoCalculado:F2}");
        }
    }
}