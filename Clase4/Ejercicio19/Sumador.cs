using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Sumador
    {

        private int cantidadSumas;

        //Constructores
        public Sumador(int valor)
        {
            this.cantidadSumas = valor;
        }

        public Sumador()
            : this(0) { }

        //Metodos

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + " " + b;
        }

        //Sobrecargas de operadores
        public static explicit operator int(Sumador a)
        {
            return a.cantidadSumas;
        }

        public static long operator +(Sumador a, Sumador b)
        {
            return a.cantidadSumas + b.cantidadSumas;
        }

        public static bool operator |(Sumador a, Sumador b)
        {
            bool retorno = false;

            if (a.cantidadSumas == b.cantidadSumas)
                retorno = true;
            
            return retorno;
        }

    }
}
