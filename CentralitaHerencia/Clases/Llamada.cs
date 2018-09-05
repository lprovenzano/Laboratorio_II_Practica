using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion
        #region Propiedades
        public abstract float CostoLlamada { get; }
        public float Duracion { get { return duracion; } }
        public string NumeroDestino { get { return nroDestino; } }
        public string NumeroOrigen { get { return nroOrigen; } }
        #endregion
        #region Metodos

        //Ctor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }


        public int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            return l1.Duracion.CompareTo(l2.Duracion);
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LLAMADA");
            sb.AppendLine("------------------------------------");
            sb.AppendLine("DURACION: " + this.Duracion);
            sb.AppendLine("NUMERO ORIGEN: " + this.NumeroOrigen);
            sb.AppendLine("NUMERO DESTINO: " + this.NumeroDestino);

            return sb.ToString();
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.Equals(l2) && (l1.NumeroOrigen == l2.NumeroOrigen) && (l1.NumeroDestino == l2.NumeroDestino))
                return true;
            else
                return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        #endregion
    }
}
