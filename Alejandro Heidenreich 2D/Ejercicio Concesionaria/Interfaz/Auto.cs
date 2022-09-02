using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Auto
    {
        public enum EMarca
        {
            Chevrolet, Fiat, Ford, Renault, Toyota, Honda, BMW, Audi, MercedezBenz
        }

        private EMarca marca;
        private string modelo;
        private string patente;
        private ConsoleColor color;
        private bool importado;
        private double precioBase;
        private bool tipoDeNieve;
        private int año;

        public Auto(EMarca marca,string patente, ConsoleColor color, bool importado, double precio, bool tipoDeNieve, string modelo, int año)
        {
            this.marca = marca;
            this.color = color;
            this.importado = importado;
            this.precioBase = precio;
            this.tipoDeNieve = tipoDeNieve;
            this.modelo = modelo;
            this.año = año;
            this.patente = patente;
        }

        public bool Importado
        {
            get { return this.importado; }
        }

        public double PrecioBase
        {
            get { return this.precioBase; }
        }
        public string MostrarDatosDelAuto(Auto autoAMostrar)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {autoAMostrar.marca}");
            sb.Append($"Modelo: {autoAMostrar.modelo}");
            if (autoAMostrar.importado)
            {
                sb.AppendLine(" - Importado");
            }
            else
            {
                sb.AppendLine();
            }
            sb.AppendLine($"Año: {autoAMostrar.año}");
            sb.AppendLine($"Color: {autoAMostrar.color}");
            sb.AppendLine($"Precio: {autoAMostrar.precioBase}");
 
            return sb.ToString();
        }

        public static bool operator ==(Auto autoUno, Auto autoDos)
        {
            return autoUno.patente == autoDos.patente;
        }

        public static bool operator !=(Auto autoUno, Auto autoDos)
        {
            return !(autoUno == autoDos);
        }
        public override bool Equals(object obj)
        {
            Auto auto = obj as Auto;
            return auto != null && (auto.patente == this.patente);
        }

        public override int GetHashCode()
        {
            return patente.GetHashCode();
        }
    }
}
