using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
            Console.WriteLine("\nLibro agregado correctamente.");
        }

        public void ListarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("\nNo hay libros registrados en la biblioteca.");
                return;
            }

            Console.WriteLine("\n--- LISTA DE LIBROS ---");
            foreach (var libro in libros)
            {
                libro.MostrarInformacion();
                Console.WriteLine("--------------------------");
            }
        }

        public void BuscarLibroPorTitulo(string titulo)
        {
            var libroEncontrado = libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (libroEncontrado != null)
            {
                Console.WriteLine("\n🔍 Libro encontrado:");
                libroEncontrado.MostrarInformacion();
            }
            else
            {
                Console.WriteLine($"\nNo se encontró ningún libro con el título \"{titulo}\".");
            }
        }
    }
}
