using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo="";

            Boligrafo boligrafoRojo = new Boligrafo(100, ConsoleColor.Red);
            Boligrafo boligrafoAzul = new Boligrafo(50, ConsoleColor.Blue);

            if (boligrafoRojo.Pintar(20, out dibujo))
            {
                Console.ForegroundColor = boligrafoRojo.GetColor();
                Console.WriteLine(dibujo);
            }
            Console.ReadKey(true);
            Console.Clear();
            if (boligrafoAzul.Pintar(10, out dibujo))
            {
                Console.ForegroundColor = boligrafoAzul.GetColor();
                Console.WriteLine(dibujo);
            }
            Console.ReadKey(true);
           
        }
    }
}
