using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Entrada
    {
        public static bool PedirEntero(string mensaje, string mensajeError, out int numeroIngresado)
        {
            bool exito = false;
            string numeroStrIngresado;

            do
            {
                Console.WriteLine(mensaje);
                numeroStrIngresado = Console.ReadLine();

                if(int.TryParse(numeroStrIngresado, out numeroIngresado))
                {
                    exito = true;
                }
                else
                {
                    mensaje = mensajeError;
                }

            } while (!exito);

            return exito;
        }

    }
}
