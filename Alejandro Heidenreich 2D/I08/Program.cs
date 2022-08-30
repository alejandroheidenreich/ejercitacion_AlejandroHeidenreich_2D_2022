//Escribir un programa que imprima por consola un triángulo como el siguiente:

//*         
//***
//*****
//*******
//*********

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

            Console.WriteLine("Ingrese la altura del triangulo");

            while (!int.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Reingrese la altura del triangulo");
            }

            sb = ElTrianguloDefinido(altura);

            Console.WriteLine(sb);
        }

        static StringBuilder ElTrianguloDefinido(int altura)
        {
            StringBuilder sb = new StringBuilder();
            string linea = "";
            int contadorDeImpares = 0;
            int indice = 1;

            while (contadorDeImpares < altura)
            {
                if (indice % 2 != 0)
                {
                    contadorDeImpares++;
                    for (int i = 0; i < indice; i++)
                    {
                        linea += "*";
                    }
                    sb.AppendLine(linea);

                }
                indice++;
                linea = "";
            }
            return sb;
        }
    }
}

