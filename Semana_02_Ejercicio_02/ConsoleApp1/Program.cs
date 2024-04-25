using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                List<Arma> inventario = new List<Arma>();

                // Crear instancias de proyectiles
                Proyectil flecha = new Proyectil("Flecha", 10);
                Proyectil bala = new Proyectil("Bala", 20);

                // Crear instancias de armas
                Espada espada = new Espada("Espada", 30, 1, 100);
                Arco arco = new Arco("Arco", 20, 2, 150, flecha);
                Pistola pistola = new Pistola("Pistola", 25, 3, 200, bala);

                // Agregar armas al inventario
                inventario.Add(espada);
                inventario.Add(arco);
                inventario.Add(pistola);

                while (true)
                {
                    Console.WriteLine("\n1. Agregar arma");
                    Console.WriteLine("2. Mostrar inventario");
                    Console.WriteLine("3. Eliminar arma del inventario");
                    Console.WriteLine("4. Terminar programa");
                    Console.Write("Seleccione una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            AgregarArma(inventario);
                            break;
                        case "2":
                            MostrarInventario(inventario);
                            break;
                        case "3":
                            EliminarArma(inventario);
                            break;
                        case "4":
                            Console.WriteLine("¡Gracias por usar el programa!");
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }
            }

            static void AgregarArma(List<Arma> inventario)
            {
                Console.Write("Ingrese el nombre del arma: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el daño del arma: ");
                int danio = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese la velocidad de ataque del arma: ");
                int velocidadAtaque = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el precio del arma: ");
                int precio = Convert.ToInt32(Console.ReadLine());

                Console.Write("¿El arma es a distancia? (s/n): ");
                string esADistancia = Console.ReadLine();
                if (esADistancia.ToLower() == "s")
                {
                    Console.Write("Ingrese el nombre del proyectil: ");
                    string nombreProyectil = Console.ReadLine();
                    Console.Write("Ingrese el daño del proyectil: ");
                    int danioProyectil = Convert.ToInt32(Console.ReadLine());
                    Proyectil proyectil = new Proyectil(nombreProyectil, danioProyectil);
                    inventario.Add(new ArmaDistancia(nombre, danio, velocidadAtaque, precio, proyectil));
                }
                else
                {
                    inventario.Add(new Arma(nombre, danio, velocidadAtaque, precio));
                }

                Console.WriteLine("¡Arma agregada al inventario!");
            }

            static void MostrarInventario(List<Arma> inventario)
            {
                if (inventario.Count > 0)
                {
                    Console.WriteLine("Inventario:");
                    for (int i = 0; i < inventario.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {inventario[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("El inventario está vacío.");
                }
            }

            static void EliminarArma(List<Arma> inventario)
            {
                if (inventario.Count > 0)
                {
                    Console.WriteLine("Eliminar arma del inventario:");
                    MostrarInventario(inventario);
                    Console.Write("Ingrese el número del arma a eliminar: ");
                    int indice = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (indice >= 0 && indice < inventario.Count)
                    {
                        inventario.RemoveAt(indice);
                        Console.WriteLine("¡Arma eliminada del inventario!");
                    }
                    else
                    {
                        Console.WriteLine("¡Número de arma no válido!");
                    }
                }
                else
                {
                    Console.WriteLine("El inventario está vacío.");
                }
            }

        }
    }

