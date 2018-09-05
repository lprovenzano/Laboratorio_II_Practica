using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Ejercicio
{
    public class Estante
    {
        //Atribb
        private Producto[] productos;
        private int ubicacionEstante;

        //Ctor
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        //Metodos
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < e.productos.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                sb.AppendLine();
            }

            sb.AppendLine("ESTANTE: " + e.ubicacionEstante);

            return sb.ToString();
        }

        //Sobrecarga
        public static bool operator ==(Estante e, Producto p)
        {
            for (int j = 0; j < e.productos.Length; j++)
            {
                if (e.productos[j] == p)
                {
                    return true;
                }
                break;

            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            if (e == p)
                return false;

            return true;
        }

        public static bool operator +(Estante e, Producto p)
        {
           
            if (e.productos.Contains(null) && !e.productos.Contains(p))
            {
                int i = Array.IndexOf(e.productos, null);
                e.productos[i] = p;

                return true;
            }
            return false;
        }

        public static bool operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                int i = Array.IndexOf(e.productos, p);
                e.productos[i] = null;

                return true;
            }

            return false;
        }

    }
}
