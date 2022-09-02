using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Gerente
    {
        private string nombre;
        private int edad;
        private int antiguedad;
        private double ganancia;

        public Gerente(string nombre, int edad, int antiguedad, double ganancia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.antiguedad = antiguedad;
            this.ganancia = ganancia;
        }

        public double Ganacia 
        { 
            set { this.ganancia += value; }
        }
    }
}
