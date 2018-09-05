using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clases
{
    public class PuestoAtencion
    {
        #region Atributos
        private static int numeroActual;
        private Puesto puesto;
        #endregion

        #region Propiedades
        public static int NumeroActual { 
            get { 
                return numeroActual + 1; 
            }
        }
        #endregion

        #region Metodos
        private static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool AtenderCliente(Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
        }

        public enum Puesto { Caja1, Caja2}

        #endregion
    }
}
