using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Negocio
    {
        #region Atributos

        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #endregion
        #region Props
        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if (!clientes.Contains(Cliente))
                {
                    clientes.Enqueue(Cliente);
                }
            }
        }
        #endregion
        #region Metodos
        private Negocio() {
            this.caja 
        }
        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        #endregion
    }
}
