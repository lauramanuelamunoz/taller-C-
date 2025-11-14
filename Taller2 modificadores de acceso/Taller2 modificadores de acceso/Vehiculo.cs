using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_modificadores_de_acceso
{
    public class Vehiculo
    {
        //privados
        private string marca;
        private string modelo;
        private double kilometraje;

        // Atributo "clases hijas"
        protected double costo;

        public Vehiculo(string marca, string modelo, double kilometrajeInicial)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.kilometraje = kilometrajeInicial;
            this.costo = 0;
        }

        //mostrar informacion basica
        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Kilometraje: {kilometraje} km");
        }

        public double ObtenerKilometraje()
        {
            return kilometraje;
        }

        public void ActualizarKilometraje(double nuevoKilometraje)
        {
            if (nuevoKilometraje > kilometraje)
            {
                kilometraje = nuevoKilometraje;
            }
        }

        //protegido
        protected double CalcularCostoMantenimiento()
        {
            costo = kilometraje * 0.05;
            return costo;
        }
    }
}