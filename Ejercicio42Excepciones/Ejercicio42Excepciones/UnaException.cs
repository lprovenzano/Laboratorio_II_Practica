using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42Excepciones
{
    class UnaException : Exception
    {
        public UnaException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
            throw new MiException("Mi Exception", innerException);
        }
    }
}
