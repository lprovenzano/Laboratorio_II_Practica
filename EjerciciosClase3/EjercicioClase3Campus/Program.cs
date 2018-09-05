using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase3Campus
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, opcion;
            bool flag;
            Calculador calculadora = new Calculador();
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero binario: ");
                if (Int32.TryParse(Console.ReadLine(), out x))
                {

                    calculadora.Acumular(x.ToString());
                }
                else
                {
                    Console.WriteLine("Debe ser un entero.");
                }

                Console.WriteLine("Continuar S/N");
                char rta = Convert.ToChar(Console.ReadLine());
                flag = EjerciciosClase3.Validacion.Valida_S(rta);

            } while (flag);
            Console.Clear();
            do
            {
                Console.WriteLine("1 - Resultado en Binario");
                Console.WriteLine("2 - Resultado en Entero");
                Console.WriteLine("0 - Salir");
                
                if (Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine(calculadora.getResultadoEnBinario());
                            break;
                        case 2:
                            Console.WriteLine(calculadora.getResultadoEnDecimal());
                            break;
                    }
                }

            } while (opcion != 0);
            Console.ReadKey();
        }
    }
}
