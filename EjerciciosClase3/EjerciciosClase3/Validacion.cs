using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClase3
{
    public class Validacion
    {
        public static bool Validar(int valor, int desde, int hasta)
        {
            if (valor < desde || valor > hasta)
            {
                return false;
            }

            return true;
        }

        public static bool Valida_S(char letra)
        {
            letra = Convert.ToChar(letra.ToString().ToLower());
            if (!(letra == 's'))
                return false;
            else
                return true;
        }

    }
}
