using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42Excepciones
{
    public static class Division
    {
        public static double Operar(double a, double b)
        {
            try
            {
                if (b == 0)
                    throw new DivideByZeroException("No podes dividir por cero");
                else
                    return a / b;

            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("Una excepcion...", e);
            }
            
        }
    }
}
