using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_modificadores_de_acceso
{
    public class Gerente : Empleado
    {
        public Gerente(string nombre, string cargo, double salarioInicial)
            : base(nombre, cargo, salarioInicial)
        {
        }

        public void MostrarSalarioConBono()
        {
            double salarioBase = ObtenerSalario();
            double bono = salarioBase * 0.10; 
            double total = salarioBase + bono;

            Console.WriteLine($"Salario base: ${salarioBase:F2}, Bono: ${bono:F2}, Total: ${total:F2}");
        }
    }
}