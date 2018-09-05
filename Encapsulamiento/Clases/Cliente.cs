using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        #region Atributos
        private string nombre;
        private int numero;
        #endregion
        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Numero
        {
            get { return this.numero; }
        }
        #endregion
        #region Metodos
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre)
            : this(numero)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecarga
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(c1.numero == c2.numero)
                return true;
            else
                return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            if (c1 == c2)
                return false;
            else
                return true;
        }
        #endregion

    }
}
