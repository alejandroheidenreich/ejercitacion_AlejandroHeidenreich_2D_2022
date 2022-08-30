using System;

namespace Prestamo_Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta primerCuenta = new Cuenta("Roberto S.A.", 1000);

            Console.WriteLine(primerCuenta.GetTitular());

            primerCuenta.IngresarMontoACuenta(500.5555);

            Console.WriteLine(primerCuenta.GetCantidad().ToString("N2"));

            primerCuenta.RetirarMontoDeCuenta(250);

            Console.WriteLine(primerCuenta.GetCantidad().ToString("N2"));

            Console.WriteLine(primerCuenta.MostrarCuenta());
        }
    }
}
