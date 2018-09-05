using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class FalloLogException : Exception
    {
        #region Metodos

        public FalloLogException(string mensaje)
            : this(mensaje, null)
        {
           
        }

        public FalloLogException(string mensaje, Exception innerException)
             : base(mensaje, innerException)
        {
           
        }

        #endregion
    }
}
