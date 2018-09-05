using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CentralitaException : Exception
    {
        #region Atributos
        private string nombreDeClase;
        private string nombreDeMetodo;
        #endregion

        #region Propiedades

        public string NombreDeClase
        {
            get
            {
                return this.nombreDeClase;
            }
        }
        public string NombreDeMetodo
        {
            get
            {
                return this.nombreDeMetodo;
            }
        }

        #endregion

        #region Metodos

        public CentralitaException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null)
        {
           
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
             : base(mensaje, innerException)
        {
            this.nombreDeClase = clase;
            this.nombreDeMetodo = metodo;
        }

        #endregion



    }
}
