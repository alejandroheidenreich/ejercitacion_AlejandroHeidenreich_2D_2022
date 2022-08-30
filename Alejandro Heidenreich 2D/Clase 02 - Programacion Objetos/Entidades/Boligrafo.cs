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
        
        private void SetTinta(short tinta)
        {
            if (tinta <= CANTIDADTINTAMAXIMA)
            {
                this.tinta = tinta;
            }
        }
        public void Recargar()
        {
            SetTinta(CANTIDADTINTAMAXIMA);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            int restoTinta;
            dibujo = "";

            if (gasto < GetTinta())
            {
                restoTinta = (int)GetTinta() - gasto;

                this.SetTinta((short)restoTinta);
                for (int i = 0; i < gasto; i++)
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
