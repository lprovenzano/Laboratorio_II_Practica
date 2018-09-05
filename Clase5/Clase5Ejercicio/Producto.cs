using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Ejercicio
{
    public class Producto
    {
        //Atributos
        protected string codigoDeBarra;
        protected string marca;
        protected float precio;

        //Ctor
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        //Métodos
        public string GetMarca()
        {
            return this.marca;
        }

        public string GetCodigoBarras()
        {
            return this.codigoDeBarra;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO: " + p.GetCodigoBarras());
            sb.AppendLine("MARCA: " + p.GetMarca());
            sb.AppendLine("PRECIO: $" + p.GetPrecio());
            sb.AppendLine("--------------------------------------------");

            return sb.ToString();
        }

        //Sobrecargas
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto a, Producto b)
        {
            if ((a.codigoDeBarra == b.codigoDeBarra) && (a.GetMarca() == b.GetMarca()))
                return true;
            return false;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            if ((a.codigoDeBarra == b.codigoDeBarra) && (a.GetMarca() == b.GetMarca()))
                return false;
            return true;
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (p.GetMarca() == marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            if (p.GetMarca() == marca)
                return false;
            return true;
        }

    }
}
