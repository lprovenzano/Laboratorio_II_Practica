using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("1 - Convertir de Binario a Decimal");
                Console.WriteLine("2 - Convertir de Decimal a Binario");
                Console.WriteLine("0 - Salir\n");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("INGRESE BINARIO: ");
                            string bin = Console.ReadLine();
                            {
                                Console.Clear();
                                Console.WriteLine("-> " + bin + " equivale a " + Conversor.BinarioDecimal(bin));
                                Console.WriteLine("\n\nPresione una tecla para continuar...");
                                Console.ReadKey(true);
                                Console.Clear();
                            }
                            break;
                        case 2:
                            double x;
                            Console.Clear();
                            Console.WriteLine("INGRESE DECIMAL: ");
                            if(double.TryParse(Console.ReadLine(), out x))
                            {
                                Console.Clear();
                                Console.WriteLine("-> " + x + " equivale a " + Conversor.DecimalBinario(x));
                                Console.WriteLine("\n\nPresione una tecla para continuar...");
                                Console.ReadKey(true);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Debe ser un numero decimal.");
                            }
                            
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Debe seleccionar una opcion válida.\n");
                            break;
                    }
                }

            } while (opcion != 0);
        }
    }
}
