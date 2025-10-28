using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_modificadores_de_acceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------Caso1---------------------------------------
            //Camion camion1 = new Camion("Volvo", "FH16", 120000);
            //Camion camion2 = new Camion("Scania", "R500", 85000);

            ////Informacion
            //Console.WriteLine("=== Camión 1 ===");
            //camion1.MostrarInformacion();
            //camion1.MostrarCostoMantenimiento();

            //Console.WriteLine("\n=== Camión 2 ===");
            //camion2.MostrarInformacion();
            //camion2.MostrarCostoMantenimiento();

            //---------------------------------------Caso2---------------------------------------
            //Console.WriteLine("=== Registro de Empleados ===");

            //List<Empleado> empleados = new List<Empleado>();

            //for (int i = 1; i <= 2; i++)
            //{
            //    Console.WriteLine($"\nEmpleado {i}:");

            //    Console.Write("Nombre: ");
            //    string nombre = Console.ReadLine();

            //    //cargo
            //    string cargo;
            //    while (true)
            //    {
            //        Console.Write("Cargo (Empleado/Gerente): ");
            //        cargo = Console.ReadLine().Trim().ToLower();

            //        if (cargo == "empleado" || cargo == "gerente")
            //            break;

            //        Console.WriteLine("Solo se permite 'Empleado' o 'Gerente'. Intente nuevamente.");
            //    }

            //    Console.Write("Salario inicial: ");
            //    double salario;
            //    while (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
            //    {
            //        Console.Write("Ingrese un salario válido: ");
            //    }

            //    if (cargo == "gerente")
            //    {
            //        Gerente gerente = new Gerente(nombre, "Gerente", salario);
            //        empleados.Add(gerente);
            //    }
            //    else
            //    {
            //        Empleado empleado = new Empleado(nombre, "Empleado", salario);
            //        empleados.Add(empleado);
            //    }
            //}

            //Console.WriteLine("\n=== Información de Empleados ===");
            //foreach (Empleado emp in empleados)
            //{
            //    emp.MostrarInformacion();

            //    if (emp is Gerente gerente)
            //    {
            //        gerente.MostrarSalarioConBono();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Este empleado no recibe bono.");
            //    }

            //    Console.WriteLine();
            //}

            //-------------------------------Caso3----------------------------------------------
            Console.WriteLine("=== Catálogo de Libros ===");

            List<Libro> catalogo = new List<Libro>();

            Libro libro1 = new Libro("Cien años de soledad", "Gabriel García Márquez", 417);
            Libro libro2 = new Libro("El Principito", "Antoine de Saint-Exupéry", 96);

            LibroDigital libro3 = new LibroDigital("1984", "George Orwell", 328, 1.8);
            LibroDigital libro4 = new LibroDigital("Sapiens", "Yuval Noah Harari", 498, 3.2);

            catalogo.Add(libro1);
            catalogo.Add(libro2);
            catalogo.Add(libro3);
            catalogo.Add(libro4);

            foreach (Libro libro in catalogo)
            {
                libro.MostrarInformacion();

                if (libro is LibroDigital digital)
                {
                    digital.MostrarResumenDigital();
                }
                else
                {
                    Console.WriteLine("Este es un libro físico.");
                }

                Console.WriteLine();

            }
        }
    }
}
