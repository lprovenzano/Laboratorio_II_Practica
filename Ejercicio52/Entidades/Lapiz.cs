using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        //Atribb
        private float tamanioMina;

        //Props
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

         float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            ((IAcciones) this).UnidadesDeEscritura = unidades;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            float cantidadDeChars = texto.Length;
            ((IAcciones) this).UnidadesDeEscritura = this.tamanioMina - (cantidadDeChars * 0.1F);

            return new EscrituraWrapper(texto, ((IAcciones) this).Color);
        }

         bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LAPIZ");
            sb.AppendLine("------------------------");
            sb.AppendLine(string.Format("Color: {0} | Nivel de mina: {1}", ((IAcciones) this).Color, ((IAcciones) this).UnidadesDeEscritura));
            return sb.ToString();
        }
    }
}
