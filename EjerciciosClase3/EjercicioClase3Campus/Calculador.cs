using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase3Campus
{
    public class Calculador
    {
        private int acumulador;

        public Calculador()
        {
            this.acumulador = 0;
        }

        public void Acumular(string bin)
        {
            this.acumulador += (int)Conversor.BinarioDecimal(bin);
        }

        public string getResultadoEnBinario()
        {
            return Conversor.DecimalBinario(acumulador);
        }

        public int getResultadoEnDecimal()
        {
            return this.acumulador;
        }
    }
}
