using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class ControlCarga
    {
        private List<Camion> camiones;
        private Random random = new Random();

        public ControlCarga()
        {
            camiones = new List<Camion>();
        }

        public void EjecutarCarga()
        {
            Console.WriteLine("=== Sistema de Carga de Alcohol ===");

            for (int i = 1; i <= 20; i++)
            {
                double capacidadCamion = random.Next(18000, 28001);
                Camion camion = new Camion(i, capacidadCamion);

                Console.WriteLine($"\nIniciando carga del camión #{i} (capacidad {capacidadCamion} litros)");

                while (true)
                {
                    double capacidadTanque = random.Next(3000, 9001);
                    TanqueAlcohol tanque = new TanqueAlcohol(capacidadTanque);

                    if (!camion.AgregarTanque(tanque))
                    {
                        Console.WriteLine($"Tanque de {capacidadTanque} L excede la capacidad. 🚚 Despachando camión #{i}...");
                        break;
                    }
                }

                camion.MostrarCarga();
                camiones.Add(camion);
            }

            MostrarResumen();
        }

        private void MostrarResumen()
        {
            Console.WriteLine("\n=== RESUMEN DEL DÍA ===");
            double totalLitros = 0;

            foreach (var camion in camiones)
            {
                totalLitros += camion.CargaActual;
            }

            Console.WriteLine($"Se cargaron 20 camiones con un total de {totalLitros:N0} litros de alcohol.");
        }
    }
}
