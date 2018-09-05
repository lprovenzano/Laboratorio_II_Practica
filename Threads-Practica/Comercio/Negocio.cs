using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Comercio
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1 { get { return this.caja1; } }
        public Caja Caja2 { get { return this.caja2; } }
        public List<string> Clientes { get { return this.clientes; } }

        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            clientes = new List<string>();
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando caja...");
            Thread.Sleep(1000);
            
            foreach (var item in Clientes)
            {
                if (this.Caja1.FilaClientes.Count <= this.Caja2.FilaClientes.Count)
                {
                    this.Caja1.FilaClientes.Add(item);
                }
                else
                {
                    this.Caja2.FilaClientes.Add(item);
                }

                Thread.Sleep(1000);
            }
        }

    }
}
