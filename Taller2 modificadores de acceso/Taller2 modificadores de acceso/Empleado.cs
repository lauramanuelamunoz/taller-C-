using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_modificadores_de_acceso
{
    public class Empleado
    {
        //privados
        private string nombre;
        private string cargo;
        private double salario;
        public Empleado(string nombre, string cargo, double salarioInicial)
        {
            this.nombre = nombre;
            this.cargo = cargo;
            this.salario = salarioInicial;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Cargo: {cargo}");
        }

        protected double ObtenerSalario()
        {
            return salario;
        }

        private void ModificarSalario(double nuevoSalario)
        {
            if (nuevoSalario > 0)
            {
                salario = nuevoSalario;
            }
        }

        public void ActualizarSalarioDesdeAdministracion(double nuevoSalario)
        {
            ModificarSalario(nuevoSalario);
        }
    }
}