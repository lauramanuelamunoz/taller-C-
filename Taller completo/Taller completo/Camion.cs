using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class Camion
    {
        public int NumeroCamion { get; set; }
        public double CapacidadMaxima { get; set; }
        public double CargaActual { get; private set; }
        public List<TanqueAlcohol> TanquesCargados { get; private set; }

        public Camion(int numero, double capacidad)
        {
            NumeroCamion = numero;
            CapacidadMaxima = capacidad;
            CargaActual = 0;
            TanquesCargados = new List<TanqueAlcohol>();
        }

        public bool AgregarTanque(TanqueAlcohol tanque)
        {
            if (CargaActual + tanque.CapacidadLitros <= CapacidadMaxima)
            {
                TanquesCargados.Add(tanque);
                CargaActual += tanque.CapacidadLitros;
                return true;
            }
            else
            {
                return false; 
            }
        }

        public void MostrarCarga()
        {
            Console.WriteLine($"\nCamión #{NumeroCamion} | Capacidad máxima: {CapacidadMaxima} litros");
            Console.WriteLine($"Carga actual: {CargaActual} litros");
            Console.WriteLine($"Tanques cargados: {TanquesCargados.Count}");
        }
    }
}
