using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Conversor
    {
        public static string DecimalBinario(double numDecimal)
        {
            string binario="";
            int numDecimalInt = Convert.ToInt32(numDecimal);

            if (numDecimalInt == 0)
            {
                binario = "0";
            }

            while (numDecimalInt > 0)
            {
                //Traigo el resto.
                double operacion = numDecimalInt % 2;
                //Divido
                numDecimalInt /= 2;
                if (operacion==0 || operacion ==1)
                {
                    binario += Convert.ToString(operacion) + "";
                }
            }
            
            return ReverseString(binario);

        }
        public static double BinarioDecimal(string numBinario)
        {
            numBinario = ReverseString(numBinario);
            int digito;
            int i = 0;
            double numDouble=0;

            while(numBinario.Contains("0") || numBinario.Contains("1"))
            {
                digito = (int)Char.GetNumericValue(numBinario[i]);
                numDouble += digito * (Math.Pow(2, i));
                i++;
                
                if(i==numBinario.Length)
                {
                    break;
                }
            }

            return (int) numDouble;

        }

        /// <summary>
        /// Revierte un string del último al primero.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
