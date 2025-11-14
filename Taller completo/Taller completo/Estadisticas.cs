using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class Estadisticas
    {
        private List<Conductor> conductores;
        private int anioActual = 2025;

        public Estadisticas(List<Conductor> listaConductores)
        {
            conductores = listaConductores;
        }

        public double PorcentajeMenores30()
        {
            int contador = 0;
            foreach (var c in conductores)
            {
                if (c.CalcularEdad(anioActual) < 30)
                    contador++;
            }
            return (double)contador / conductores.Count * 100;
        }

        public double PorcentajeSexo(int sexo)
        {
            int contador = 0;
            foreach (var c in conductores)
            {
                if (c.Sexo == sexo)
                    contador++;
            }
            return (double)contador / conductores.Count * 100;
        }

        public double PorcentajeMasculinos12a30()
        {
            int contador = 0;
            foreach (var c in conductores)
            {
                int edad = c.CalcularEdad(anioActual);
                if (c.Sexo == 2 && edad >= 12 && edad <= 30)
                    contador++;
            }
            return (double)contador / conductores.Count * 100;
        }

        public double PorcentajeFueraBogota()
        {
            int contador = 0;
            foreach (var c in conductores)
            {
                if (c.Registro == 2)
                    contador++;
            }
            return (double)contador / conductores.Count * 100;
        }
    }
}
