using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Torneo <T>
    {
        #region Atributos
        private List<T> equipos;
        private string nombre;
        #endregion
        #region Metodos
        public static bool operator ==(List<T> ListaEquipos, U equipo)
        {
            return ListaEquipos.Contains(equipo);
        }

        public static bool operator !=(List<T> ListaEquipos, U equipo)
        {
            return !(ListaEquipos == equipo);
        }

        public static List<T> operator +(List<T> ListaEquipos, U equipo)
        {
            if (!ListaEquipos == equipo)
                ListaEquipos.Add(equipo);

        }

        
    
        #endregion
    }//class
}//namespace
