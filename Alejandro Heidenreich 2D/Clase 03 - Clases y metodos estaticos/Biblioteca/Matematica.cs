using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Matematica
    {
        public static int CalcularFactorial (int numeroIngresado)
        {
            if(numeroIngresado == 0 || numeroIngresado == 1)
            {
                return 1;
            }
            return numeroIngresado * CalcularFactorial(numeroIngresado-1);
        }
    }
}
