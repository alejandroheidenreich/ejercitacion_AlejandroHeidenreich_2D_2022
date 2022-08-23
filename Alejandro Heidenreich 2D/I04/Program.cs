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
            int numero;
            bool validacionNumero;
            string mensajeDeEntradaNumero = "Ingrese un numero";
            int contadorDeNumerosPerfectos = 0;

            do
            {
                Console.WriteLine(mensajeDeEntradaNumero);
                
            } while (int.TryParse(Console.ReadLine(), out numero)) ;





        }
    }
}
