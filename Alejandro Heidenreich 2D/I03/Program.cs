//Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

//Validar que el dato ingresado por el usuario sea un número.

//Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

//Si ingresa "salir", cerrar la consola.

//Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

using System;

namespace I03
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuestaParaContinuar = "";
            string numeroCadenaIngresado;
            int numero;
            string mensajeDeEntradaDeDatos = "Ingrese un numero";
            bool vaildacionNumeroIngresado = true;
            int contadorDeRestosCero;


            while (respuestaParaContinuar != "salir")
            {
                do
                {
                    
                    Console.WriteLine(mensajeDeEntradaDeDatos);
                    numeroCadenaIngresado = Console.ReadLine();

                    if (int.TryParse(numeroCadenaIngresado, out numero))
                    {
                        mensajeDeEntradaDeDatos = "Ingrese un numero";
                        vaildacionNumeroIngresado = true;
                        for (int i = 2; i < numero; i++)
                        {
                            contadorDeRestosCero = 0;
                            for (int j = 2; j <= i; j++)
                            {
                                if (i % j == 0)
                                {
                                    contadorDeRestosCero += 1;
                                }
                            }
                            if (contadorDeRestosCero == 1)
                            {
                                Console.WriteLine($"{i} es primo");
                            }                         
                        }
                    }
                    else
                    {
                        mensajeDeEntradaDeDatos = "ERROR. ¡Reingresar número! o Escriba (salir)";
                        vaildacionNumeroIngresado = false;
                        if (numeroCadenaIngresado == "salir")
                        {
                            Environment.Exit(0);
                        }
                    }
                } while (!vaildacionNumeroIngresado);

                Console.WriteLine("Desea volver a operar? si/salir");
                respuestaParaContinuar = Console.ReadLine();
            }
        }
    }
}

