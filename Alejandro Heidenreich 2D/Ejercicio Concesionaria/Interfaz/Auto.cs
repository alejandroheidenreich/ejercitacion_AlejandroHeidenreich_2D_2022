using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Auto
    {
        private string descripcion;
        private bool importado;
        private double precioBase;
        private bool tipoDeNieve;
        private int ano;

        public Auto(string descripcion, bool importado, double precioBase, bool tipoDeNieve, int ano)
        {
            this.descripcion = descripcion;
            this.importado = importado;
            this.precioBase = precioBase;
            this.tipoDeNieve = tipoDeNieve;
            this.ano = ano;
        }

        public bool Importado
        {
            get { return this.importado; }
        }

        public double PrecioBase
        {
            get { return this.precioBase; }
        }

        public int Ano
        {
            get { return this.ano; }
        }

        public bool TipoDeNieve
        {
            get { return this.tipoDeNieve; }
        }

        public static string MostrarDatosDelAuto(Auto autoAMostrar)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Descripcion: {autoAMostrar.descripcion}"); 
            if (autoAMostrar.importado)
            {
                sb.AppendLine(" - Importado");
            }
            else
            {
                sb.AppendLine();
            }
            sb.AppendLine($"Año: {autoAMostrar.ano}");
            sb.AppendLine($"Precio: {autoAMostrar.precioBase}");
 
            return sb.ToString();
        }

        public static bool operator ==(Auto autoUno, Auto autoDos)
        {
            return autoUno.descripcion == autoDos.descripcion
                && autoUno.importado == autoDos.importado
                && autoUno.ano == autoDos.ano
                && autoUno.precioBase == autoDos.precioBase;
        }

        public static bool operator !=(Auto autoUno, Auto autoDos)
        {
            return !(autoUno == autoDos);
        }
        public override bool Equals(object obj)
        {
            Auto auto = obj as Auto;
            return auto != null && this == auto;
        }

        public override int GetHashCode()
        {
            return descripcion.GetHashCode();
        }
    }
}
