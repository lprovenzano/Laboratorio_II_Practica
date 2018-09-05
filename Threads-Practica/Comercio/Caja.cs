using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Comercio
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes { get { return this.filaClientes; } }

        public void AtenderClientes()
        {
            foreach (var item in FilaClientes)
            {
                Console.WriteLine("{0}--> {1}", Thread.CurrentThread.Name, item);
                Thread.Sleep(2000);
            }
        }
        public Caja()
        {
            this.filaClientes = new List<string>();
        }
    }
}
