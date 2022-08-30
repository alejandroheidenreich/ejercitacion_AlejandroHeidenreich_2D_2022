using System;

namespace I03_Universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumnoUno = new Estudiante("Raul", "Gomez", "13456");
            Estudiante alumnoDos = new Estudiante("Homero", "Simpson", "17456");
            Estudiante alumnoTres = new Estudiante("Luca", "Prodan", "19899");

            alumnoUno.SetNotaPrimerParcial(8);
            alumnoUno.SetNotaSegundoParcial(7);
            alumnoDos.SetNotaPrimerParcial(6);
            alumnoDos.SetNotaSegundoParcial(4);
            alumnoTres.SetNotaPrimerParcial(2);
            alumnoTres.SetNotaSegundoParcial(3);

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());
            
        }
    }
}
