//Escribir un programa que imprima por consola un triángulo como el siguiente:

//        *
//       ***
//      *****
//     *******
//    *********
//El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
using System;
using System.Text;

namespace I09
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int altura;
            char simbolo;

            Console.WriteLine("Ingrese la altura del triangulo");

            while (!int.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Reingrese la altura del triangulo");
            }

            Console.WriteLine("Ingrese el simbolo con el cual quiere armar el triangulo");
            simbolo = Console.ReadKey().KeyChar;

            Console.Clear();

            sb = ArmarTriangulo(altura, simbolo);

            Console.WriteLine(sb);
        }

        
        static int CalcularBase(int altura)
        {
            int baseTriangulo = 1;
            int contadorDeImpares = 0;
            int indice = 1;

            while (contadorDeImpares<altura)
            {
                if (indice % 2 != 0)
                {
                    contadorDeImpares++;
                    baseTriangulo = indice;
                }
                indice++;
            }
            return baseTriangulo;
        }

        static string CalcularLinea (int baseTriangulo, int linea,char simbolo)
        {
            int cantidadDeEspaciados = (baseTriangulo - linea)/2;
            int cantidadLineaTotal = baseTriangulo - cantidadDeEspaciados;
            string lineaStr = "";
            for (int i = 0; i < cantidadLineaTotal; i++)
            {
                if (i < cantidadDeEspaciados)
                {
                    lineaStr += ' ';
                }
                else
                {
                    lineaStr += simbolo;
                }
            }
            return lineaStr;
        }

        static StringBuilder ArmarTriangulo(int altura, char simbolo)
        {
            StringBuilder sb = new StringBuilder();
            int baseTriangulo = CalcularBase(altura);
            int lineaLargo = baseTriangulo;
            string lineaStr;
            for (int i = altura; i > 0; i--)
            {
                lineaStr = CalcularLinea(baseTriangulo,lineaLargo, simbolo);
                sb.Insert(0, lineaStr + Environment.NewLine);
                lineaLargo -= 2;
            }
            return sb;
        }
    }
}
