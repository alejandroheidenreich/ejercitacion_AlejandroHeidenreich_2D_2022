using Biblioteca;
using System;


namespace Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuestaContinuar;
            bool respuestaFinal;
            bool respuestaValidacion = true;
            int numeroIngresado;
            int acumuladorDeSumaEnteros = 0;

            do
            {
                Entrada.PedirEntero("Ingrese un numero ", "ERROR - Reingrese un numero entero ", out numeroIngresado);

                acumuladorDeSumaEnteros += numeroIngresado;

                do
                {
                    if (!respuestaValidacion)
                    {
                        Console.WriteLine("No es una respueta valida");

                    }
                    Console.WriteLine("Desea Ingresar otro numero? si/no");
                    respuestaContinuar = Console.ReadLine();
                    respuestaValidacion = Validador.ValidarRespuesta(respuestaContinuar, "si", "no", out respuestaFinal);
                } while (!respuestaValidacion);


            } while (respuestaFinal);

            Console.WriteLine($"El total de la suma es: {acumuladorDeSumaEnteros}");
        }
    }
}
