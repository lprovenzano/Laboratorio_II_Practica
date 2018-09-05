using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        #region Atrib
            private byte nota1;
            private byte nota2;
            private float notaFinal;

            public string nombre;
            public string apellido;
            public int legajo;
        #endregion

        #region Metodos
            public void Estudiar(byte nota1, byte nota2)
            {
                this.nota1 = nota1;
                this.nota2 = nota2;
            }

            public void CalcularFinal()
            {
                if (this.nota1 >= 4 && this.nota2 >= 4)
                {
                    Random rand = new Random();
                    this.notaFinal = rand.Next(0,10);

                }
            }

            public Alumno(string nombre, string apellido, int legajo)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.legajo = legajo;
                this.notaFinal = -1;
            }

            public string Mostrar()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Nombre: " + this.nombre);
                sb.Append("\n\nApellido: " + this.apellido);
                sb.Append("\n\nLegajo: " + this.legajo);
                if (this.notaFinal != -1)
                {
                    sb.Append("\n\n\nNOTA: " + this.notaFinal);
                }
                else
                {
                    sb.Append("\n\n\nALUMNO DESAPROBADO");
                }

                return sb.ToString();

            }

        #endregion
    }
}
