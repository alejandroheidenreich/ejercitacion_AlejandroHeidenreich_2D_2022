using System;

namespace Entidades
{
    public class Boligrafo
    {
        
        const short CANTIDADTINTAMAXIMA = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }
        
        private bool SetTinta(short tinta)
        {
            int resultado = (int)this.tinta + tinta;
            bool exito = false;

            if (resultado <= CANTIDADTINTAMAXIMA && resultado >= 0)
            {
                this.tinta = (short)resultado;
                exito = true;
            }
            return exito;
        }
        public void Recargar()
        {
            this.tinta = CANTIDADTINTAMAXIMA;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";

            if (SetTinta(gasto))
            {
                for (int i = 0; i < gasto*-1; i++)
                {
                     dibujo += "*";
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
