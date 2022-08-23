//Ingresar 5 números por consola, guardándolos en una variable escalar.
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

using System;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = 6;
            int minimo = 9;
            string numeroStr;
            bool flag = true;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");

                numeroStr = Console.ReadLine();

                if (int.TryParse(numeroStr, out numero))
                {
                    if (flag)
                    {
                        maximo = numero;
                        minimo = numero;
                        flag = false;
                    }
                    else
                    {
                        if (numero > maximo)
                        {
                            maximo = numero;
                        }
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                    }
                }
                else
                {
                    Console.Write($"El dato ingresado en el puesto {i + 1} no es un numero");
                }

            }

            if (flag)
            {
                Console.Write($"No se ingresaron numeros");
            }
            else
            {
                Console.Write($"El numero mayor es {maximo} {Environment.NewLine} El numero menor es {minimo}");
            }
        }
    }
}
