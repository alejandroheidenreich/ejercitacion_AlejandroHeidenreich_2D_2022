using Biblioteca;
using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int factorialDelNumero;
            Entrada.PedirEntero("Ingrese un numero entero","ERROR - No es un numero entero", out numeroIngresado);

            factorialDelNumero = Matematica.CalcularFactorial(numeroIngresado);

            Console.WriteLine($"El factorial de {numeroIngresado} es: {factorialDelNumero}");
        }
    }
}
