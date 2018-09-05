using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int x, max = 0, min = 0, promedio = 0;

            while (i < 4)
            {
                Console.WriteLine("Ingrese un numero entero {0}: ", i+1);
                if (Int32.TryParse(Console.ReadLine(), out x))
                {
                    if (Validacion.Validar(x, -100, 100))
                    {
                        if (max == 0 && min == 0 && promedio == 0)
                        {
                            max = x;
                            min = x;
                            promedio = x;
                        }
                        else
                        {
                            if (x > max)
                            {
                                max = x;
                            }
                            if (x < min)
                            {
                                max = x;
                            }

                            promedio += x;
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Debe ser un numero.");
                }
                i++;
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("RESULTADO ---------------------------");
            Console.WriteLine("MAXIMO {0}\nMINIMO {1}\nPROMEDIO {2}", max, min, promedio/i);
            Console.ReadKey();
        }
    }
}
