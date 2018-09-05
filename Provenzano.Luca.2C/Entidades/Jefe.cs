using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jefe : Persona
    {
        #region Atributos
        private DateTime fechaIngreso;
        #endregion
        #region Propiedades

        /// <summary>
        /// Propiedad que devuelve la cantidad de dias de antiguedad desde el ingreso.
        /// </summary>
        public int Antiguedad
        {
            get
            {
                int antiguedad = (int)(DateTime.Today - this.fechaIngreso).TotalDays;
                return antiguedad;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Imprime en pantalla los datos de la entidad Jefe.
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("ANTIGUEDAD: " + Antiguedad);

            return sb.ToString();
        }

        /// <summary>
        /// Constructor entidad Jefe.
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellido</param>
        /// <param name="documento">DNI</param>
        public Jefe(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {
        }

        /// <summary>
        /// Constructor entidad Jefe.
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellido</param>
        /// <param name="documento">DNI</param>
        /// <param name="fechaIngreso">Fecha de ingreso laboral</param>
        public Jefe(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        /// <summary>
        /// Valida que la documentacion del Jefe tenga 8 caracteres.
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            if (doc.Length != 8)
                return false;
            else
                return true;
        }

        #endregion

    }//Fin Clase
}//Fin NameSpace
