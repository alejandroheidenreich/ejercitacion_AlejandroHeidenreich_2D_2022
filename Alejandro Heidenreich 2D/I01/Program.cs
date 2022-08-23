//Ingresar 5 números por consola, guardándolos en una variable escalar.
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

using System;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int maximo = 6;
            int minimo = 9;
            int promedioNumeros;
            int contadorDeNoNumeros = 0;
            int acumuladorNumeros = 0;
            string numeroStr;
            bool banderaPrimeroNumero = true;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");

                numeroStr = Console.ReadLine();

                if (int.TryParse(numeroStr, out numeroIngresado))
                {
                    acumuladorNumeros += numeroIngresado;
                    if (banderaPrimeroNumero)
                    {
                        maximo = numeroIngresado;
                        minimo = numeroIngresado;
                        banderaPrimeroNumero = false;
                    }
                    else
                    {
                        if (numeroIngresado > maximo)
                        {
                            maximo = numeroIngresado;
                        }
                        if (numeroIngresado < minimo)
                        {
                            minimo = numeroIngresado;
                        }
                    }
                }
                else
                {
                    Console.Write($"El dato ingresado en el puesto {i + 1} no es un numero");
                    contadorDeNoNumeros++;
                }

            }

            if (banderaPrimeroNumero)
            {
                Console.Write($"No se ingresaron numeros");
            }
            else
            {
                promedioNumeros = acumuladorNumeros / (5 - contadorDeNoNumeros);
                Console.Write($"El numero mayor es {maximo} {Environment.NewLine}El numero menor es {minimo}{Environment.NewLine}El promedio de los numeros ingreados es {promedioNumeros}");
            }
        }
    }
}
