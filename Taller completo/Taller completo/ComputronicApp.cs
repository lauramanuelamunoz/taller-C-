using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class ComputronicApp
    {
        private List<Empleado> empleados = new List<Empleado>();
        private const double sueldoBase = 500000;

        public void RegistrarEmpleados()
        {
            Console.Write("Ingrese el número de empleados: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\n=== Empleado #{i + 1} ===");
                Console.Write("Nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el valor total de ventas realizadas: $");
                double venta = double.Parse(Console.ReadLine());

                empleados.Add(new Empleado(nombre, venta));
            }
        }

        public void CalcularBonificaciones()
        {
            foreach (var emp in empleados)
            {
                double porcentaje = 0;

                if (emp.Venta >= 800000)
                    porcentaje = 0.10;
                else if (emp.Venta >= 400000)
                    porcentaje = 0.05;
                else if (emp.Venta >= 300000)
                    porcentaje = 0.03;

                emp.Bonificacion = emp.Venta * porcentaje;
                emp.PagoTotal = sueldoBase + emp.Bonificacion;
            }
        }

        public void MostrarResultados()
        {
            Console.WriteLine("\n=== RESULTADOS ===");

            int menores300 = empleados.Count(e => e.Venta <= 300000);
            int entre300y800 = empleados.Count(e => e.Venta > 300000 && e.Venta < 800000);
            int mayores800 = empleados.Count(e => e.Venta >= 800000);

            Console.WriteLine($"\nVentas ≤ $300.000: {menores300}");
            Console.WriteLine($"Ventas > $300.000 y < $800.000: {entre300y800}");
            Console.WriteLine($"Ventas ≥ $800.000: {mayores800}");

            Console.WriteLine("\n--- Detalle por empleado ---");
            foreach (var e in empleados)
            {
                Console.WriteLine($"\nEmpleado: {e.Nombre}");
                Console.WriteLine($"Venta: {e.Venta:C0}");
                Console.WriteLine($"Bonificación: {e.Bonificacion:C0}");
                Console.WriteLine($"Pago total (sueldo + bonificación): {e.PagoTotal:C0}");
            }

            double totalVentas = empleados.Sum(e => e.Venta);
            double totalBonos = empleados.Sum(e => e.Bonificacion);
            Console.WriteLine("\n=== RESUMEN GENERAL ===");
            Console.WriteLine($"Total de ventas realizadas: {totalVentas:C0}");
            Console.WriteLine($"Total en bonificaciones pagadas: {totalBonos:C0}");
            Console.WriteLine($"Total pagado (sueldos + bonificaciones): {(totalBonos + sueldoBase * empleados.Count):C0}");
        }
    }
}
