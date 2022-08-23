//Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!". (Utilizar el método Pow de la clase Math para calcular las potencias.)
using System;

namespace I02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroCadena;
            double resultadoDeOperacion;
            string mensajeDeEntradaDeDatos = "Ingrese un numero";
            bool validacionDelNumero = true;

            while (validacionDelNumero)
            {
                Console.WriteLine(mensajeDeEntradaDeDatos);
                numeroCadena = Console.ReadLine();
                if (int.TryParse(numeroCadena, out numero))
                {
                    validacionDelNumero = false;
                    resultadoDeOperacion = Math.Pow(numero, 2);
                    Console.WriteLine($"{numero} elevado al cuadrado es: {resultadoDeOperacion}");
                    resultadoDeOperacion = Math.Pow(numero, 3);
                    Console.WriteLine($"{numero} elevado al cubo es: {resultadoDeOperacion}");
                }
                else
                {
                    mensajeDeEntradaDeDatos = "ERROR. ¡Reingresar número!";
                }
            } 
            
        }
    }
}
