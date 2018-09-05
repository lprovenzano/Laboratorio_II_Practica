using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        public List<IAcciones> cartuchera;

        public bool ProbarElementos()
        {
            cartuchera = new List<IAcciones>();
            foreach (var item in cartuchera)
            {
                if (item.UnidadesDeEscritura > 0)
                {
                    item.UnidadesDeEscritura -= 1; 
                }

                if (item.UnidadesDeEscritura <= 0)
                    item.Recargar(10);
            }

            if (cartuchera != null)
                return true;
            else
                return false;
        }
    }
}
