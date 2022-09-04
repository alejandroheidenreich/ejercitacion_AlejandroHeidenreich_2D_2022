using Entidades;
using System;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Boligrafo boligrafoUno = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoDos = new Boligrafo(ConsoleColor.Red, 50);
            string dibujo;

            Console.WriteLine($"Color del primer boligrafo: {boligrafoUno.GetColor()}");
            Console.WriteLine($"Nivel de tinta del primer boligrafo: {boligrafoUno.GetTinta()}");
            Console.WriteLine($"Color del segundo boligrafo: {boligrafoDos.GetColor()}");
            Console.WriteLine($"Nivel de tinta del segundo boligrafo: {boligrafoDos.GetTinta()}");

            boligrafoDos.Recargar();
            Console.WriteLine($"Nivel de tinta del segundo boligrafo: {boligrafoDos.GetTinta()}");

            boligrafoUno.Pintar(-10, out dibujo);
            Console.WriteLine($"Nivel de tinta del primer boligrafo: {boligrafoUno.GetTinta()}");
            Console.ForegroundColor = boligrafoUno.GetColor();
            Console.WriteLine(dibujo);

            Console.ForegroundColor = ConsoleColor.White;

            boligrafoDos.Pintar(-25, out dibujo);
            Console.WriteLine($"Nivel de tinta del primer boligrafo: {boligrafoDos.GetTinta()}");
            Console.ForegroundColor = boligrafoDos.GetColor();
            Console.WriteLine(dibujo);

        }
    }
}
