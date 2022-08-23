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
                            if (EsPrimo(i))
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

        static bool EsPrimo(int numero)
        {
            int contadorDeRestosCero = 0;
            bool esPrimo = false;

            for (int i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contadorDeRestosCero++;

                }
                if (contadorDeRestosCero > 1)
                {
                    break;
                }
            }

            if (contadorDeRestosCero == 1)
            {
                esPrimo = true;
            }
     
            return esPrimo;

        }
    } 
}

