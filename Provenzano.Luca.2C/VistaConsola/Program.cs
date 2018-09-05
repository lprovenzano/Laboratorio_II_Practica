using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            // Genero un oficina nuevo
            Oficina oficina = new Oficina(2, Departamentos.A, new Jefe("Fede", "Dávila", "12345678", new
            DateTime(2015, 03, 20)));
            // Genero empleados...
            Empleado a1 = new Empleado("Juan", "López", "22-3333-2", 2, Departamentos.A);
            Empleado a2 = new Empleado("José", "Martínez", "23-3343-6", 2, Departamentos.B);
            Empleado a3 = new Empleado("María", "Gutiérrez", "22-3333-2", 2, Departamentos.A);
            Empleado a4 = new Empleado("Marta", "Rodríguez", "23-3343-6", 2, Departamentos.A);
            Empleado a5 = new Empleado("Marta", "Rodríguez", "233343126", 2, Departamentos.A);
            // ... Y los agrego al oficina
            oficina += a1;
            oficina += a2;
            oficina += a3;
            oficina += a4;
            oficina += a5;
            // Imprimo los datos del oficina
            Console.WriteLine((string)oficina);
            Console.ReadKey();

        }
    }//Fin Clase
}//Fin NameSpace
