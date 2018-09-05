using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private string documento;
        private string nombre;
        #endregion
        #region Propiedades

        /// <summary>
        /// Propiedad Apellido (GET)
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Propiedad Documento (GET/SET)
        /// </summary>
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (ValidarDocumentacion(this.documento))
                    this.documento = value;
            }
        }

        /// <summary>
        /// Propiedad Nombre (GET)
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion
        #region Metodos

        /// <summary>
        /// Genera una nueva Persona
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellido</param>
        /// <param name="documento">Documento</param>
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        /// <summary>
        /// Imprime en pantalla los datos de la entidad Persona.
        /// </summary>
        /// <returns></returns>
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE: " + Nombre);
            sb.AppendLine("APELLIDO: " + Apellido);
            sb.AppendLine("NOMBRE: " + Documento);
            
            return sb.ToString();
        }

        /// <summary>
        /// Valida la documentación de la entidad.
        /// </summary>
        /// <returns>true / false en caso de ser o no correcta</returns>
        protected abstract bool ValidarDocumentacion(string doc);

        #endregion

    }//Fin Clase
}//Fin NameSpace
