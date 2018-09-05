using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2
    {
        public List<Boligrafo> listaBoligrafo;
        public List<Lapiz> listaLapiz;

        public bool ProbarElementos(Boligrafo b, Lapiz l)
        {
            this.listaBoligrafo = new List<Boligrafo>();
            this.listaLapiz = new List<Lapiz>();

            listaBoligrafo.Add(b);
            listaLapiz.Add(l);

            foreach (var item in listaBoligrafo)
            {
                if (item.UnidadesDeEscritura > 0)
                {
                    item.UnidadesDeEscritura -= 1;
                }

                if (item.UnidadesDeEscritura <= 0)
                    item.Recargar(10);
            }

            foreach (var item in listaLapiz)
            {
                if (((IAcciones)item).UnidadesDeEscritura > 0)
                {
                    ((IAcciones)item).UnidadesDeEscritura -= 1;
                }

                if (((IAcciones)item).UnidadesDeEscritura <= 0)
                    ((IAcciones)item).Recargar(10);
            }

            if (listaBoligrafo != null && listaLapiz!=null)
                return true;
            else
                return false;
        }
    }
}
