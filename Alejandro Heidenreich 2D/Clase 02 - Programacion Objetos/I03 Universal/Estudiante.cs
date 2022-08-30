using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace I03_Universal
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;      
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (float)(notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = Estudiante.random.Next(6,10);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal;

            sb.AppendLine($"{this.nombre} {this.apellido} - Legajo: {this.legajo}");
            sb.AppendLine($"Nota del primer parcial: {this.notaPrimerParcial}\n " +
                        $"Nota del segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            notaFinal = this.CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();
        }
    }
}
