using System;

namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarNumero (int valor, int valorMinimo, int valorMaxixmo)
        {
            return valor > valorMinimo && valor < valorMaxixmo;
        }
 
        public static bool ValidarRespuesta(string respuesta, string afirmativo, string negativo, out bool respuestaValidada)
        {
            bool validacionRespuesta = false;
            respuestaValidada = false;

            if (respuesta == afirmativo)
            {
                validacionRespuesta = true;
                respuestaValidada = true;
            }
            else
            {
                if (respuesta == negativo)
                {
                    validacionRespuesta = true;
                    respuestaValidada = false;
                }
            }

            return validacionRespuesta;
        }

    }
}
