using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(10);
            Sumador s2 = new Sumador(10);
            
            Console.WriteLine(s1 + s2);
            Console.WriteLine(s1 | s2);

            Console.WriteLine(s1.Sumar(10, 100));
            Console.WriteLine(s1.Sumar("Luca", "Eros"));

            Console.ReadKey();
        }
    }
}
