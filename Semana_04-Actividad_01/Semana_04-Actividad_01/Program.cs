using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_04_Actividad_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;

            while(continueFlag)
            {
                Console.WriteLine("Introducir número");
                Console.WriteLine("1. Fibonaccie");
                Console.WriteLine("2. Primo");
                Console.WriteLine("3. Perfecto");
                Console.WriteLine("4. Salir");

                String option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Console.WriteLine("Introduzca el valor de n para generar la secuencia de Fibonacci:");
                        int n1 =int.Parse(Console.ReadLine());
                        Fibonacci fib = new Fibonacci(n1);
                        fib.Generar();

                        break;

                    case "2":
                        Console.WriteLine("Introduzca el valor de n para generar la secuencia:");
                        int n2 = int.Parse(Console.ReadLine());
                        Primo primo = new Primo(n2);
                        primo.GenerarPrimo();

                        break;

                    case "3":
                        Console.WriteLine("Ingrese el límite superior para generar la secuencia de números perfectos:");
                        int limite = int.Parse(Console.ReadLine());

                        
                        Perfecto perfecto = new Perfecto(limite);
                        perfecto.GenerarPerfecto();

                        break;

                   

                    case "4": 
                        continueFlag = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;


                }

            }

        }
    }
}
