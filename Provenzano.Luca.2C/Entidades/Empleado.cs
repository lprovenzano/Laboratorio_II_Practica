using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Atributos
        private Departamentos departamento;
        private short piso;
        #endregion 

        #region Propiedades
        /// <summary>
        /// Propiedad que retorna el piso y el departamento
        /// </summary>
        public string PisoDepartamento
        {
            get
            {
                string pisoDepartamento = piso.ToString()+"ª"+this.departamento;
                return pisoDepartamento;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Constructor entidad Empleado.
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellido</param>
        /// <param name="documento">DNI</param>
        /// <param name="piso">Piso</param>
        /// <param name="departamento">Departamento</param>
        public Empleado(string nombre, string apellido, string documento, short piso, Departamentos departamento)
            : base(nombre, apellido, documento)
        {
            this.piso = piso;
            this.departamento = departamento;
        }


        /// <summary>
        /// Imprime en pantalla los datos de la entidad Empleado.
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("PISO y DEPARTAMENTO: " + PisoDepartamento);

            return sb.ToString();
        }

        /// <summary>
        /// Valida que la documentacion tenga formato XX-XXXX-X
        /// </summary>
        /// <returns></returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            Regex rgx = new Regex(@"^[0-9]{2}-[0-9]{4}-[0-9]{1}?$");

            if (rgx.IsMatch(doc))
                return true;
            else
                throw new Exception("No se pudo cargar");
        }

        #endregion

    }//Fin Clase
}//Fin NameSpace
