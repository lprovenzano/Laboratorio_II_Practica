using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Provincial : Llamada
    {
        #region Atributos
        protected Franja franjaHoraria;

        //Declaro constantes para el precio segun la franja.
        const float Franja1Costo = 0.99F;
        const float Franja2Costo = 1.25F;
        const float Franja3Costo = 0.66F;

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

        //Ctors
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NumeroOrigen, miFranja, llamada.Duracion, llamada.NumeroDestino)
        {
        }

        private float CalcularCosto()
        {
            float resultado = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    resultado += this.Duracion * Franja1Costo;
                    break;
                case Franja.Franja_2:
                    resultado += this.Duracion * Franja2Costo;
                    break;
                case Franja.Franja_3:
                    resultado += this.Duracion * Franja3Costo;
                    break;
            }
            return resultado;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Provincial)");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("COSTO:" + this.CostoLlamada);
            sb.AppendLine("FRANJA:" + this.franjaHoraria);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Provincial)
                return true;
            else
                return false;
        }

        #endregion
    }
}
