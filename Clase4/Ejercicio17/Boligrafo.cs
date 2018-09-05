using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    public class Boligrafo
    {
        #region Atributos
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region Metodos

        public Boligrafo(short cantidadDeTinta, ConsoleColor colorBoligrafo)
        {
            if (cantidadDeTinta > 0 && cantidadDeTinta <= 100)
            {
                this.tinta = cantidadDeTinta;
                if (this.tinta > cantidadTintaMaxima)
                    Recargar();
            }
            this.color = colorBoligrafo;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short cantidadDeTinta)
        {
            if (cantidadDeTinta > 0)
            {
                this.tinta += cantidadDeTinta;

                if (this.tinta > cantidadTintaMaxima)
                    this.tinta = cantidadTintaMaxima;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";

            if (this.tinta > 0)
            {
                if (this.tinta > (short)gasto)
                {
                    for (int i = 0; i < gasto; i++)
                    {
                        dibujo += "*";
                    }
                }
                else
                {
                    for (int i = 0; i < this.tinta; i++)
                    {
                        dibujo += "*";
                    }
                }
                this.tinta -= (short)gasto;

                if (this.tinta < 0)
                    this.tinta = 0;

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
