using System;
using Biblioteca;

namespace Interfaz_Ejercicio_2_clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuestaContinuar;
            bool respuestaValidada;
            do
            {
                Entrada.PedirEntero("Ingrese un numero entre -100 y 100", "ERROR - Reingrese un numero entero entre 100 y -100", out numeroIngresado);

                //cread 
                while (ValidarRespuesta(respuestaContinuar, "si", "no", respuestaValidada))
                {
                    Console.WriteLine();
                }
            } while (true);

        }
    }
}
