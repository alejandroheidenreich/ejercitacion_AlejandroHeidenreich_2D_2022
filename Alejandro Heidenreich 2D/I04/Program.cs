//Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

//El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

//Escribir una aplicación que encuentre los 4 primeros números perfectos.

//Utilizar sentencias de iteración y selectivas.

//Para conocer más sobre los números perfectos, consultar el siguiente enlace a Wikipedia.

using System;

namespace I04
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorDeNumerosPerfectos = 0;
            int numeroEntero = 1;

            Console.WriteLine("Lista de numeros Perfectos");
            while (contadorDeNumerosPerfectos < 4)
            {
                if (EsPerfecto(numeroEntero))
                {
                    contadorDeNumerosPerfectos++;
                    Console.WriteLine(numeroEntero);
                }
                numeroEntero++;
            }
        }

        static bool EsDivisor (int numero, int divisor)
        {
            return divisor != 0 && numero % divisor == 0;
        }

        static bool EsPerfecto (int numero)
        {
            int acumuladorDeDivisores = 0;
            bool esPerfecto = false;
            for (int i = 1; i < numero; i++)
            {
                if (EsDivisor(numero,i))
                {
                    acumuladorDeDivisores += i;
                }
            }
            if (acumuladorDeDivisores == numero)
            {
                esPerfecto = true;
            }
            return esPerfecto;
        }
    }
}
