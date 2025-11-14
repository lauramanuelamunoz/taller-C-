using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_modificadores_de_acceso
{
    public class Libro
    {
        //privados
        private string titulo;
        private string autor;
        private int paginas;

        public Libro(string titulo, string autor, int paginasIniciales)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginasIniciales;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {titulo}, Autor: {autor}, Páginas: {paginas}");
        }

        private void ModificarPaginas(int nuevasPaginas)
        {
            if (nuevasPaginas > 0)
            {
                paginas = nuevasPaginas;
            }
        }

        public void ActualizarPaginasDesdeSistema(int nuevasPaginas)
        {
            ModificarPaginas(nuevasPaginas);
        }

        protected string GenerarResumen()
        {
            return $"Resumen: '{titulo}' por {autor}, contiene {paginas} páginas.";
        }
    }
}