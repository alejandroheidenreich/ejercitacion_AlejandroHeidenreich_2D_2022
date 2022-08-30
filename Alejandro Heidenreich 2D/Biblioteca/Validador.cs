using System;

namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarNumero (int valor, int valorMinimo, int valorMaxixmo)
        {
            return valor > valorMinimo && valor < valorMaxixmo;
        }

        
        
    }
}
