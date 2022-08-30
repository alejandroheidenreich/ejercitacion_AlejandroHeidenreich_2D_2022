//Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

//El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.

//Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

using System;

namespace I05
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite;
            Console.WriteLine("Ingrese el limite de la busqueda");
            while(!int.TryParse(Console.ReadLine(), out limite) || limite < 0)
            {
                Console.WriteLine("Reingrese el limite de la busqueda");
            }

            if (!ListaDeCentros(limite))
            {
                Console.WriteLine("No se encontro ningun centro numerico");
            }
            
        }

        static bool ListaDeCentros (int limite)
        {
            bool esCentro = false;
            int sumatoriaDeAnteriores;
            int sumatoriaDePosteriores;

            for (int i = 2; i < limite; i++)
            {
                sumatoriaDeAnteriores = SumatoriaDeAnteriores(i);
                sumatoriaDePosteriores = SumatoriaDePosteriores(i, sumatoriaDeAnteriores);
                if (sumatoriaDeAnteriores == sumatoriaDePosteriores)
                {
                    esCentro = true;
                    Console.WriteLine($"{i} es un centro numerico");
                }

            }

            return esCentro;
        }

        static int SumatoriaDeAnteriores (int numero)
        {
            int acumuladorDeAnteriores = 0;
            for (int i = 1; i < numero; i++)
            {
                acumuladorDeAnteriores += i;
            }

            return acumuladorDeAnteriores;
        }
        static int SumatoriaDePosteriores (int inicio, int final)
        {
            int acumuladorDePosteriores = 0;
            for (int i = inicio+1; i <= final; i++)
            {
                acumuladorDePosteriores += i;
                if (acumuladorDePosteriores >= final)
                {
                    break;
                }
            }
            return acumuladorDePosteriores;
        }
    }
}
