using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Luca", "Provenzano", 030312);
            Alumno a2 = new Alumno("Loana", "Pranteda", 030313);
            Alumno a3 = new Alumno("Samuel", "Naranja", 030314);

            a2.Estudiar(10, 3);
            a2.CalcularFinal();
            Console.WriteLine(a2.Mostrar());
            Console.ReadKey();
            Console.Clear();

            a1.Estudiar(10, 10);
            a1.CalcularFinal();
            Console.WriteLine(a1.Mostrar());
            Console.ReadKey();
            Console.Clear();

            a3.Estudiar(5, 7);
            a3.CalcularFinal();
            Console.WriteLine(a3.Mostrar());
            Console.ReadKey();

        }
    }
}
