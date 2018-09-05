using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Local : Llamada
    {
        #region Atributos
        protected float costo;
        #endregion
        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion
        #region Metodos

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NumeroOrigen, llamada.Duracion, llamada.NumeroDestino, costo)
        {
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Local)");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("COSTO: " + this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if (obj!=null && obj is Local)
                return true;
            else
                return false;
        }

        #endregion
    }
}
