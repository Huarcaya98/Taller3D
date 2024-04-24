using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string optionGeneral;
            do
            {
                Console.WriteLine("Elija qué operación desea realizar:");
                Console.WriteLine("1. Area y perimero del Rectangulo");
                Console.WriteLine("2. Area del Triangulo");
                Console.WriteLine("3. Año Bisiesto");
                Console.WriteLine("4. Calculadora");
                Console.WriteLine("5 Area y/o Perimetro de una figura");
                Console.WriteLine("6 Area de una figura");
                optionGeneral = Console.ReadLine();

                switch(optionGeneral)
                { 
                    case "1":
                        
                            Console.WriteLine("Ingrese la base del Rectangulo");              
                            float baseRectangulo01 = float.Parse(Console.ReadLine());                       
                            Console.WriteLine("Ingrese la altura del rectangulo");
                            float alturaRectangulo01 = float.Parse(Console.ReadLine());
                            Rectangulo rectangulo01 = new Rectangulo(baseRectangulo01, alturaRectangulo01);
                            Console.WriteLine("El area del rectangulo es:" + rectangulo01.CalcularArea());
                            Console.WriteLine("El perimetro es:" + rectangulo01.CalcularPerimetro());
       
                       
                    break;

                    case "2":

                            Console.WriteLine("Ingrese la base del triángulo:");
                            float baseTriangulo01 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del triángulo:");
                            float alturaTriangulo01 = float.Parse(Console.ReadLine());
                            Triangulo triangulo01 = new Triangulo(baseTriangulo01, alturaTriangulo01);
                            Console.WriteLine("El área del triángulo es: " + triangulo01.CalcularArea());
                       
                    break;
                      

                    case "3":
                        Console.WriteLine("Ingrese el año");
                        int anio = int.Parse(Console.ReadLine());
                        Bisiesto bisiesto = new Bisiesto(anio);
                        Console.WriteLine(bisiesto.ResultadoBisiesto());

                        break;

                    case "4":
                        float num1, num2;
                        string operacion;
                        bool continueFlag = true;

                        while (continueFlag)
                        {
                            Console.WriteLine("Ingrese el primer numero");
                            num1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero");
                            num2 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la operacion a realizar");
                            operacion = Console.ReadLine();

                            switch (operacion)
                            {
                                case "suma":
                                    Console.WriteLine($"La suma es {num1 + num2}");

                                    break;
                                case "resta":
                                    Console.WriteLine($"La resta es: {num1 - num2}");

                                    break;
                                case "multiplicacion":
                                    Console.WriteLine($"La multiplicacion es: {num1 * num2}");

                                    break;
                                case "division":
                                    Console.WriteLine($"La division es: {num1 / num2}");

                                    break;
                                case "modulo":
                                    Console.WriteLine($"El modulo es: {num1 % num2}");
                                    break;


                                default:
                                    Console.WriteLine("No existes esta operacion");
                                    break;
                            }


                            Console.WriteLine("Continuar si o no");
                            string option = Console.ReadLine();

                            if (option == "no")
                            {
                                continueFlag = false;
                            }

                        }

                        break;

                    case "5":

                        
                        string figura;
                        bool continueFlag5 = true;

                        while (continueFlag5)
                        {
                            Console.WriteLine("Ingrese la figura");
                            Console.WriteLine("1: Rectangulo");
                            Console.WriteLine("2: Triangulo");
                            Console.WriteLine("3: Circulo");

                            figura = Console.ReadLine();

                            switch (figura)
                            {
                                case "1":

                                    Console.WriteLine("Ingrese la base del Rectangulo");
                                    float baseRectangulo02= float.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la altura del rectangulo"); 
                                    float alturaRectangulo02 = float.Parse(Console.ReadLine());
                                    Rectangulo rectangulo02 = new Rectangulo(baseRectangulo02, alturaRectangulo02);
                                    Console.WriteLine("El area del rectangulo es:" + rectangulo02.CalcularArea());
                                    Console.WriteLine("El perimetro del rectangulo es:" + rectangulo02.CalcularPerimetro());



                                    break;

                                case "2":

                                    Console.WriteLine("Ingrese la base del Triangulo");
                                    float baseTriangulo02 = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la altura del Triangulo");
                                    float alturaTriangulo02 = float.Parse(Console.ReadLine());
                                    Triangulo triangulo02 = new Triangulo(baseTriangulo02,alturaTriangulo02);
                                    Console.WriteLine("El area del Triangulo es:" + triangulo02.CalcularArea());
;                                   

                                    break;

                                case "3":
                                    Console.WriteLine("Ingrese el radio del círculo:");
                                    float radio01 = float.Parse(Console.ReadLine());
                                    Circulo circulo01 = new Circulo(radio01);
                                    Console.WriteLine("El área del círculo es: " + circulo01.CalcularArea());
                                    break;
                            

                                default:
                                    Console.WriteLine("No existes esta operacion");
                                    break;
                            }


                            Console.WriteLine("Continuar si o no");
                            string option = Console.ReadLine();

                            if (option == "no")
                            {
                                continueFlag5 = false;
                            }

                        }


                        break;

                    case "6":

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




                        break;

                }

                   


            }while (optionGeneral !="7");

           
        }
    }
}
