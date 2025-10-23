using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AnioPublicacion { get; set; }

        public Libro(string titulo, string autor, string editorial, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            AnioPublicacion = anioPublicacion;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"\nTítulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Editorial: {Editorial}");
            Console.WriteLine($"Año de Publicación: {AnioPublicacion}");
        }
        }
}
