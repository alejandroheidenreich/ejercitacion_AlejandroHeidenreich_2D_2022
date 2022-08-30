using System;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Roberto", 10, 10, 1989, "11598751");
            Persona personaDos = new Persona("Raul", 28, 08, 1989, "10107833");
            Persona personaTres = new Persona("Raul", 06, 03, 2010, "52366012");

            Console.WriteLine(personaUno.CalcularEdad());
            Console.WriteLine(personaDos.CalcularEdad());
            Console.WriteLine(personaTres.CalcularEdad());

            Console.WriteLine(personaUno.MostrarPersona());
            Console.WriteLine(personaUno.EsmayorDeEdad());

            Console.WriteLine(personaDos.MostrarPersona());
            Console.WriteLine(personaDos.EsmayorDeEdad());

            Console.WriteLine(personaTres.MostrarPersona());
            Console.WriteLine(personaTres.EsmayorDeEdad());
        }
    }
}
