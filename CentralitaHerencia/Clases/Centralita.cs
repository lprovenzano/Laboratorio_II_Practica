using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamada;
        protected string razonSocial;
        #endregion
        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamada;
            }
        }
        #endregion
        #region Metodos

        //Ctors
        private Centralita()
        {
            this.listaDeLlamada = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Clases.Llamada.TipoLlamada tipo)
        {
            float costoLocal = 0, costoProvincial = 0, costoTotal = 0;

            //foreach (var item in listaDeLlamada)
            //{
            //    if (tipo == Llamada.TipoLlamada.Local && item is Local)
            //    {
            //        costoLocal+=((Local)item).CostoLlamada;
            //    }
            //    if (tipo == Llamada.TipoLlamada.Provincial && item is Provincial)
            //    {
            //        costoProvincial += ((Provincial)item).CostoLlamada;
            //    }

            //    if (tipo == Llamada.TipoLlamada.Todas)
            //    {
            //        costoTotal += costoProvincial + costoLocal;
            //    }
            //}

            if (tipo == Llamada.TipoLlamada.Local)
            {
                costoLocal += listaDeLlamada.Where(x => x is Local).Sum(x => ((Local)x).CostoLlamada);
                return costoLocal;
            }
            else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                costoProvincial += listaDeLlamada.Where(x => x is Provincial).Sum(x => ((Provincial)x).CostoLlamada);
                return costoProvincial;
            }
            else
            {
                costoLocal += listaDeLlamada.Where(x => x is Local).Sum(x => ((Local)x).CostoLlamada);
                costoProvincial += listaDeLlamada.Where(x => x is Provincial).Sum(x => ((Provincial)x).CostoLlamada);

                return costoTotal = costoLocal + costoProvincial;
            }
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CENTRALITA");
            sb.AppendLine("------------------------");
            sb.AppendLine("Ganancia Local: " + this.GananciasPorLocal);
            sb.AppendLine("Ganancia Provincial: " + this.GananciasPorProvincial);
            sb.AppendLine("Ganancia Total: " + this.GananciasPorTotal);
            sb.AppendLine("");
            sb.AppendLine("------------------------");
            foreach (var item in listaDeLlamada)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("");
            sb.AppendLine("------------------------");
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamada.OrderByDescending(x => x.Duracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada l1)
        {
            this.listaDeLlamada.Add(l1);
        }

        public static Centralita operator +(Centralita C, Llamada l1)
        {
            if (!(C == l1))
                C.AgregarLlamada(l1);
            else
                throw new CentralitaException("La llamada ya se encuentra registrada en el sistema.", "Centralita", "Sobrecarga +");

            return C;
        }

        public static bool operator ==(Centralita C, Llamada l1)
        {
            bool flag = false;
            foreach (Llamada item in C.Llamadas)
            {
                if (item == l1)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static bool operator !=(Centralita C, Llamada l1)
        {
            return !(C == l1);
        }

        #endregion

    }//class

}//namespace


