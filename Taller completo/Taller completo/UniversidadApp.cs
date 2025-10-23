using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_completo
{
    internal class UniversidadApp
    {
        private List<ProgramaAcademico> programas = new List<ProgramaAcademico>();
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private const double valorCredito = 200000;

        public UniversidadApp()
        {
            // Inicializar programas con créditos y descuentos
            programas.Add(new ProgramaAcademico("Ingeniería de Sistemas", 20, 0.18));
            programas.Add(new ProgramaAcademico("Psicología", 16, 0.12));
            programas.Add(new ProgramaAcademico("Economía", 18, 0.10));
            programas.Add(new ProgramaAcademico("Comunicación Social", 18, 0.05));
            programas.Add(new ProgramaAcademico("Administración de Empresas", 20, 0.15));
        }

        public void MatricularEstudiantes()
        {
            Console.Write("Ingrese el número de estudiantes a matricular: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\n=== Estudiante #{i + 1} ===");
                Console.Write("Nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Seleccione el programa académico:");
                for (int j = 0; j < programas.Count; j++)
                    Console.WriteLine($"{j + 1}. {programas[j].Nombre}");

                int opcionPrograma = int.Parse(Console.ReadLine());
                ProgramaAcademico programaSeleccionado = programas[opcionPrograma - 1];

                Console.Write("Método de pago (Efectivo / En línea): ");
                string metodoPago = Console.ReadLine();

                estudiantes.Add(new Estudiante(nombre, programaSeleccionado, metodoPago));
            }
        }

        public void MostrarResultados()
        {
            Console.WriteLine("\n=== RESULTADOS DEL PERÍODO ACADÉMICO ===");

            // a) Estudiantes por programa
            Console.WriteLine("\nCantidad de estudiantes por programa:");
            foreach (var prog in programas)
            {
                int count = estudiantes.Count(e => e.Programa.Nombre == prog.Nombre);
                Console.WriteLine($"{prog.Nombre}: {count}");
            }

            // b) Total créditos inscritos
            int totalCreditos = estudiantes.Sum(e => e.Programa.Creditos);
            Console.WriteLine($"\nTotal de créditos inscritos: {totalCreditos}");

            // c) Valor total sin descuentos
            double valorSinDescuento = totalCreditos * valorCredito;
            Console.WriteLine($"Valor total sin descuentos: {valorSinDescuento:C0}");

            // d) Valor total de descuentos
            double totalDescuentos = estudiantes.Sum(e =>
            {
                if (e.MetodoPago.ToLower() == "efectivo")
                    return e.Programa.Creditos * valorCredito * e.Programa.Descuento;
                else
                    return 0;
            });
            Console.WriteLine($"Total descuentos aplicados: {totalDescuentos:C0}");

            // e) Valor neto
            double valorNeto = valorSinDescuento - totalDescuentos;
            Console.WriteLine($"Valor neto recibido: {valorNeto:C0}");
        }
    }
}
