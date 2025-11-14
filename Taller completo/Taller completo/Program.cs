using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------Ejercicio1-----------------------------------
            //Console.Write("Ingrese el monto del préstamo: ");
            //double monto = Convert.ToDouble(Console.ReadLine());

            //double tasaAnual = 0.05;
            //int años = 5;

            //double interesAnual = monto * tasaAnual;
            //double interesTrimestre = interesAnual / 4;
            //double interesMensual = interesAnual / 12;
            //double totalPagar = monto + (interesAnual * años);

            //Console.WriteLine("\n--- Resultados ---");
            //Console.WriteLine($"Interés pagado en un año: {interesAnual}");
            //Console.WriteLine($"Interés pagado en el tercer trimestre: {interesTrimestre}");
            //Console.WriteLine($"Interés pagado en el primer mes: {interesMensual}");
            //Console.WriteLine($"Total a pagar al final de {años} años: {totalPagar}");



            //-------------------------------------Ejercicio2----------------------------------------------
            //Console.Write("Ingrese el salario del empleado: ");
            //double salario = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Ingrese el valor del ahorro mensual programado: ");
            //double ahorro = Convert.ToDouble(Console.ReadLine());

            //double porcentajeEPS = 0.125;
            //double porcentajePension = 0.16;

            //double descuentoEPS = salario * porcentajeEPS;
            //double descuentoPension = salario * porcentajePension;
            //double totalRecibir = salario - (descuentoEPS + descuentoPension + ahorro);

            //Console.WriteLine("\n--- COLILLA DE PAGO ---");
            //Console.WriteLine($"Salario del Empleado: {salario:C2}");
            //Console.WriteLine($"Ahorro mensual programado: {ahorro:C2}");
            //Console.WriteLine($"Descuento por EPS (12.5%): {descuentoEPS:C2}");
            //Console.WriteLine($"Descuento por Pensión (16%): {descuentoPension:C2}");
            //Console.WriteLine($"--------------------------------");
            //Console.WriteLine($"Total a recibir: {totalRecibir:C2}");


            //----------------------------Ejercicio3----------------------------------------

            //Console.WriteLine("=== Registro de Persona ===");

            //Console.Write("Ingrese el nombre: ");
            //string nombre = Console.ReadLine();

            //Console.Write("Ingrese la edad: ");
            //int edad = int.Parse(Console.ReadLine());

            //Console.Write("Ingrese el género (F/M): ");
            //char genero = char.Parse(Console.ReadLine().ToUpper());

            //Console.Write("Ingrese el teléfono: ");
            //string telefono = Console.ReadLine();


            //Persona persona = new Persona(nombre, edad, genero, telefono);

            //int opcion;
            //do
            //{
            //    Console.WriteLine("\n--- Menú de Opciones ---");
            //    Console.WriteLine("1. Imprimir detalles de la persona");
            //    Console.WriteLine("2. Calcular edad en días");
            //    Console.WriteLine("3. Editar información");
            //    Console.WriteLine("4. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            persona.ImprimirDetalles();
            //            break;
            //        case 2:
            //            persona.CalcularEdadEnDias();
            //            break;
            //        case 3:
            //            persona.EditarInformacion();
            //            break;
            //        case 4:
            //            Console.WriteLine("\nSaliendo del programa...");
            //            break;
            //        default:
            //            Console.WriteLine("Opción no válida, intente de nuevo.");
            //            break;
            //    }

            //}while (opcion != 4);


            //---------------------------------------Ejercicio4---------------------------------------
            //Biblioteca biblioteca = new Biblioteca();
            //int opcion;

            //do
            //{
            //    Console.WriteLine("\n=== ADMINISTRACIÓN DE BIBLIOTECA ===");
            //    Console.WriteLine("1. Agregar un libro");
            //    Console.WriteLine("2. Listar todos los libros");
            //    Console.WriteLine("3. Buscar libro por título");
            //    Console.WriteLine("4. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.Write("\nIngrese el título del libro: ");
            //            string titulo = Console.ReadLine();

            //            Console.Write("Ingrese el autor: ");
            //            string autor = Console.ReadLine();

            //            Console.Write("Ingrese la editorial: ");
            //            string editorial = Console.ReadLine();

            //            Console.Write("Ingrese el año de publicación: ");
            //            int anio = int.Parse(Console.ReadLine());

            //            Libro nuevoLibro = new Libro(titulo, autor, editorial, anio);
            //            biblioteca.AgregarLibro(nuevoLibro);
            //            break;

            //        case 2:
            //            biblioteca.ListarLibros();
            //            break;

            //        case 3:
            //            Console.Write("\nIngrese el título del libro que desea buscar: ");
            //            string tituloBusqueda = Console.ReadLine();
            //            biblioteca.BuscarLibroPorTitulo(tituloBusqueda);
            //            break;

            //        case 4:
            //            Console.WriteLine("\nSaliendo del programa...");
            //            break;

            //        default:
            //            Console.WriteLine("\nOpción no válida, intente nuevamente.");
            //            break;
            //    }

            //} while (opcion != 4);

            //--------------------------------------Ejercicio5---------------------------------------
            //UniversidadApp app = new UniversidadApp();

            //app.MatricularEstudiantes();
            //app.MostrarResultados();

            //Console.WriteLine("\nPresione cualquier tecla para salir...");
            //Console.ReadKey();

            //-------------------------------------------Ejercicio6--------------------------------------------
            //ComputronicApp app = new ComputronicApp();

            //app.RegistrarEmpleados();
            //app.CalcularBonificaciones();
            //app.MostrarResultados();

            //Console.WriteLine("\nPresione cualquier tecla para salir...");
            //Console.ReadKey();

            //------------------------------------------------Ejercicio7--------------------------------------------------
            //List<Conductor> listaConductores = new List<Conductor>();

            //Console.Write("Ingrese la cantidad de conductores: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"\n--- Conductor {i} ---");

            //    Conductor c = new Conductor();

            //    Console.Write("Año de nacimiento: ");
            //    c.AnioNacimiento = int.Parse(Console.ReadLine());

            //    Console.Write("Sexo (1: Femenino, 2: Masculino): ");
            //    c.Sexo = int.Parse(Console.ReadLine());

            //    Console.Write("Registro del carro (1: Bogotá, 2: Otras ciudades): ");
            //    c.Registro = int.Parse(Console.ReadLine());

            //    listaConductores.Add(c);
            //}

            //Estadisticas est = new Estadisticas(listaConductores);

            //Console.WriteLine("\n--- Resultados ---");
            //Console.WriteLine($"Porcentaje de conductores menores de 30 años: {est.PorcentajeMenores30():F2}%");
            //Console.WriteLine($"Porcentaje de conductores femeninos: {est.PorcentajeSexo(1):F2}%");
            //Console.WriteLine($"Porcentaje de conductores masculinos: {est.PorcentajeSexo(2):F2}%");
            //Console.WriteLine($"Porcentaje de conductores masculinos entre 12 y 30 años: {est.PorcentajeMasculinos12a30():F2}%");
            //Console.WriteLine($"Porcentaje de conductores con carros registrados fuera de Bogotá: {est.PorcentajeFueraBogota():F2}%");

            //Console.ReadKey();

            //----------------------------------------------Ejercicio8-----------------------------------------------
            //List<EmpleadoTiktok> listaEmpleadosTiktok = new List<EmpleadoTiktok>();

            //Console.WriteLine("=== Sistema de Bonificaciones de Empleados TikTok ===");
            //Console.Write("Ingrese la cantidad de empleados TikTok: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"\n--- Empleado TikTok #{i} ---");

            //    EmpleadoTiktok empleado = new EmpleadoTiktok();

            //    Console.Write("Nombre del empleado TikTok: ");
            //    empleado.Nombre = Console.ReadLine();

            //    Console.Write("Año de nacimiento: ");
            //    empleado.AnioNacimiento = int.Parse(Console.ReadLine());

            //    Console.Write("Mes de nacimiento (1-12): ");
            //    empleado.MesNacimiento = int.Parse(Console.ReadLine());

            //    listaEmpleadosTiktok.Add(empleado);
            //}

            //EstadisticasEmpleadoTiktok estadisticas = new EstadisticasEmpleadoTiktok(listaEmpleadosTiktok);

            //Console.WriteLine("\n=== Resultados Empleados TikTok ===");
            //Console.WriteLine($"Promedio de edades: {estadisticas.CalcularPromedioEdades():F2} años");

            //estadisticas.MostrarBonosPorMes();

            //Console.WriteLine("\nPresione una tecla para salir...");
            //Console.ReadKey();


            ////-------------------------------------------Ejercicio9--------------------------------------------------
            //ControlCarga control = new ControlCarga();
            //control.EjecutarCarga();

            //Console.WriteLine("\nProceso completado. Presione una tecla para salir...");
            //Console.ReadKey();
        }
    }
}
