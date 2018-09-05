using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        //Atribs
        private ConsoleColor colorTinta;
        private float tinta;

        //Props
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        //Cto
        public Boligrafo(int unidades, ConsoleColor color)
        {
            Color = color;
            UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            float cantidadDeChars = texto.Length;
            UnidadesDeEscritura = this.tinta - (cantidadDeChars * 0.3F);

            return new EscrituraWrapper(texto, Color);
        }

        public bool Recargar(int unidades)
        {
            UnidadesDeEscritura += (float)unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BOLIGRAFO");
            sb.AppendLine("------------------------");
            sb.AppendLine(string.Format("Color: {0} | Nivel de tinta: {1}", Color, UnidadesDeEscritura));
            return sb.ToString();
        }
    }
}
