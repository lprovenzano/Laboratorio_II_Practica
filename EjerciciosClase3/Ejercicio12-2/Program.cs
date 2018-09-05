using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sumador=0;
            bool flag;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                if (Int32.TryParse(Console.ReadLine(), out x))
                {
                    
                    sumador+=x;
                }
                else
                {
                     Console.WriteLine("Debe ser un entero.");
                }

                Console.WriteLine("Continuar S/N");
                char rta = Convert.ToChar(Console.ReadLine());
                flag = EjerciciosClase3.Validacion.Valida_S(rta);

            }while(flag);

            Console.Clear();
            Console.WriteLine("RESULTADO: {0}", sumador);
            Console.ReadKey();
        }
    }
}
