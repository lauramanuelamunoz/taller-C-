using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class EstadisticasEmpleadoTiktok
    {
        private List<EmpleadoTiktok> empleadosTiktok;
        private int anioActual = 2025;
        private const double BONO = 150000;

        public EstadisticasEmpleadoTiktok(List<EmpleadoTiktok> listaEmpleados)
        {
            empleadosTiktok = listaEmpleados;
        }

        public double CalcularPromedioEdades()
        {
            double suma = 0;
            foreach (var e in empleadosTiktok)
            {
                suma += e.CalcularEdad(anioActual);
            }
            return suma / empleadosTiktok.Count;
        }

        public void MostrarBonosPorMes()
        {
            int[] empleadosPorMes = new int[12];
            double totalBonos = 0;

            foreach (var e in empleadosTiktok)
            {
                int edad = e.CalcularEdad(anioActual);

                  if (edad > 18 && edad < 50)
                {
                    empleadosPorMes[e.MesNacimiento - 1]++;
                    totalBonos += BONO;
                }
            }

            string[] meses = {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };

            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine(" Mes\t\tEmpleados TikTok\tDinero en Bonos");
            Console.WriteLine("----------------------------------------------");

            for (int i = 0; i < 12; i++)
            {
                if (empleadosPorMes[i] > 0)
                {
                    double dineroMes = empleadosPorMes[i] * BONO;
                    Console.WriteLine($" {meses[i],-10}\t{empleadosPorMes[i]} empleados TikTok\t${dineroMes:N0}");
                }
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"\nTotal de dinero en bonos que debe tener la empresa TikTok: ${totalBonos:N0}");
        }
    }
}
