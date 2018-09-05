using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Comercio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();

            Negocio negocio1 = new Negocio(c1, c2);

            c1.FilaClientes.Add("Joaquin");
            c1.FilaClientes.Add("Mariano");
            
            negocio1.Clientes.Add("Clara");
            c1.FilaClientes.Add("Juan");
            c2.FilaClientes.Add("Pedro");
            negocio1.Clientes.Add("Mayra");
            negocio1.Clientes.Add("Carlos");
            negocio1.Clientes.Add("Elisa");


            Thread TAsignarCaja = new Thread(negocio1.AsignarCaja);
            Thread TCaja1 = new Thread(c1.AtenderClientes);
            TCaja1.Name = "Caja 1";
            Thread TCaja2 = new Thread(c2.AtenderClientes);
            TCaja2.Name = "Caja 2";

            TAsignarCaja.Start();
            TAsignarCaja.Join();
            TCaja1.Start();
            TCaja2.Start();
            Console.ReadKey();

            

        }
    }
}
