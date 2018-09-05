using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Oficina
    {
        #region Atributos

        private Departamentos departamento;
        private List<Empleado> empleados;
        private Jefe jefe;
        private short piso;

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad que retorna el piso y la division de la oficina
        /// </summary>
        public string PisoDivision
        {
            get
            {
                string pisoDepartamento = piso.ToString() + "ª" + this.departamento;
                return pisoDepartamento; ;
            }
        }
        #endregion
        #region Metodos

        /// <summary>
        /// Constructor privado Oficina
        /// </summary>
        private Oficina()
        {
            empleados = new List<Empleado>();
        }

        /// <summary>
        /// Crea una nueva instancia de Oficina.
        /// </summary>
        /// <param name="piso">Piso</param>
        /// <param name="departamento">Departamento</param>
        /// <param name="jefe">Jefe</param>
        public Oficina(short piso, Departamentos departamento, Jefe jefe)
            : this()
        {
            this.piso = piso;
            this.departamento = departamento;
            this.jefe = jefe;
        }

        /// <summary>
        /// Retorna datos de la oficina y todos sus empleados.
        /// </summary>
        /// <param name="o">Obj. Oficina</param>
        /// <returns>string</returns>
        public static explicit operator string(Oficina o)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PISO y DIVISION: " + o.PisoDivision);
            sb.AppendLine("JEFE: " + o.jefe);

            foreach (Empleado item in o.empleados)
            {
                sb.AppendLine(item.ExponerDatos());
            }

            return sb.ToString();

        }

        /// <summary>
        /// Sobrecarga que verifica si el empleado pertenece al piso y division de la oficina.
        /// </summary>
        /// <param name="o">Obj. Oficina</param>
        /// <param name="e">Obj. Empleado</param>
        /// <returns>bool</returns>
        public static bool operator ==(Oficina o, Empleado e)
        {
            return o.PisoDivision == e.PisoDepartamento;
        }

        /// <summary>
        /// Sobrecarga que verifica si el empleado pertenece al piso y division de la oficina.
        /// </summary>
        /// <param name="o">Obj. Oficina</param>
        /// <param name="e">Obj. Empleado</param>
        /// <returns>bool</returns>
        public static bool operator !=(Oficina o, Empleado e)
        {
            return (!(o.PisoDivision == e.PisoDepartamento));
        }

        /// <summary>
        /// Sobrecarga del + para agregar un empleado a la lista de la oficina si este contiene el mismo piso y division.
        /// </summary>
        /// <param name="o">Obj. Oficina</param>
        /// <param name="e">Obj. Empleado</param>
        /// <returns>Obj. Oficina</returns>
        public static Oficina operator +(Oficina o, Empleado e)
        {
            if (o.PisoDivision == e.PisoDepartamento)
                o.empleados.Add(e);

            return o;
        }


        #endregion


    }//Fin Clase
}//Fin NameSpace
