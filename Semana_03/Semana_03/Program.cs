using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcion;
            do
            {
                Console.WriteLine("Elija qué figura desea operar:");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Salir");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese la base del rectángulo:");
                        float baseRectangulo = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del rectángulo:");
                        float alturaRectangulo = float.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                        Console.WriteLine("El área del rectángulo es: " + rectangulo.CalcularArea());
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el radio del círculo:");
                        float radio = float.Parse(Console.ReadLine());
                        Circulo circulo = new Circulo(radio);
                        Console.WriteLine("El área del círculo es: " + circulo.CalcularArea());
                        break;
                    case "3":
                        Console.WriteLine("Ingrese la base del triángulo:");
                        float baseTriangulo = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del triángulo:");
                        float alturaTriangulo = float.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                        Console.WriteLine("El área del triángulo es: " + triangulo.CalcularArea());
                        break;
                    case "4":
                        Console.WriteLine("¡Adiós!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

            } while (opcion != "4");

        }
    }

}
    

