using System;
using Biblioteca;

namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMaximoIngreado=6;
            int numeroMinimoIngresado=9;
            bool validacion = false;
            bool banderaPrimerNumeroIngresado = true;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                   Entrada.PedirEntero("Ingrese un numero entre -100 y 100", "ERROR - Reingrese un numero entero entre 100 y -100", out numeroIngresado);
                    if(Validador.ValidarNumero(numeroIngresado, -100, 100))
                    {
                        validacion = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No es un numero entre -100 y 100");

                        validacion = true;
                    }
                } while (validacion);

                if (banderaPrimerNumeroIngresado || numeroIngresado < numeroMinimoIngresado)
                {
                    numeroMinimoIngresado = numeroIngresado;
                }
                if (banderaPrimerNumeroIngresado || numeroIngresado > numeroMaximoIngreado)
                {
                    numeroMaximoIngreado = numeroIngresado;
                    banderaPrimerNumeroIngresado = false;
                }
            }

            Console.WriteLine($"Numero minimo ingresado fue: {numeroMinimoIngresado}");
            Console.WriteLine($"Numero maximo ingresado fue; {numeroMaximoIngreado}");
        }
    }
}
