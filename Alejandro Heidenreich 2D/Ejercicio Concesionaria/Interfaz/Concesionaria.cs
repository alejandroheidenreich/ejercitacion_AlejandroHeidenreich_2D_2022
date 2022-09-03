using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public enum EUbicaicon
    {
        Buenos_Aires, Ushuaia
    }
    internal class Concesionaria
    {
        private EUbicaicon ubicacion;
        private int capacidadMaximaDeAutos;
        private string numeroDeTelefono;
        private double gananciaTotal;
        private List<Auto> autos;
        private string nombreDeGerente;
        private double gananciaDeGerente;

        private Concesionaria()
        {
            this.autos = new List<Auto>();
            this.gananciaDeGerente = 0;
            this.gananciaTotal = 0;
        }

        public Concesionaria(EUbicaicon ubicacion, int capacidadMaximaDeAutos, string nombreDeGerente) :this()
        {
            this.ubicacion = ubicacion;
            this.capacidadMaximaDeAutos = capacidadMaximaDeAutos;
            this.nombreDeGerente = nombreDeGerente;
        }

        public Concesionaria(EUbicaicon ubicacion, int capacidadMaximaDeAutos, string nombreDeGerente, string numeroDeTelefono):this(ubicacion, capacidadMaximaDeAutos,nombreDeGerente)
        {
            this.numeroDeTelefono = numeroDeTelefono;
        }

        public string NumeroDeTelefono
        {
            set { this.numeroDeTelefono = value; }
        }

        public List<Auto> Autos
        { 
            get { return autos; } 
        }

        public double GananciaTotal { get => gananciaTotal; }
        public double GananciaDeGerente { get => gananciaDeGerente; }

        public bool AgregarAuto(Auto autoAAgregar)
        {
            bool agregado = false;

            if (autoAAgregar is not null && this.autos.Count < this.capacidadMaximaDeAutos)
            {
                if (CondicionarAccionAuto(autoAAgregar))
                {
                    this.autos.Add(autoAAgregar);
                    agregado = true;
                }
            }
            return agregado;
        }

        private bool EncontrarAuto(Auto autoABuscar)
        {
            bool encontrado = false;

            foreach (Auto item in this.autos)
            {
                if (item == autoABuscar)
                {
                    encontrado = true;
                    break;
                }
                
            }
            return encontrado;
        }

        private int EncontrarAutoPorIndice(Auto autoABuscar)
        {
            int encontrado = -1;

            for (int i = 0; i < this.autos.Count; i++)
            {
                if (this.autos[i] == autoABuscar)
                {
                    encontrado = i;
                    break;
                }
            }
            return encontrado;
        }
        public bool VenderAuto(Auto autoAVender)
        {
            double facturacion;
            bool vendido = false;

            if (EncontrarAuto(autoAVender) && CondicionarAccionAuto(autoAVender))
            {
                facturacion = autoAVender.PrecioBase;
                if (autoAVender.Importado)
                {
                    facturacion *= 1.18;
                }
                this.gananciaTotal += facturacion * .99;
                this.gananciaDeGerente += facturacion * .01;
                vendido = EliminarAuto(autoAVender);
            }

            return vendido;
        }

        public bool EliminarAuto(Auto autoAEliminar)
        {
            bool eliminado = false;
            int indice = EncontrarAutoPorIndice(autoAEliminar);

            if (indice != -1)
            {
                this.autos.RemoveAt(indice);
                eliminado = true;
            }
            return eliminado;
        }

        public string MostrarListaDeAutos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Auto item in this.autos)
            {
                sb.AppendLine(Auto.MostrarDatosDelAuto(item));
            }

            return sb.ToString();
        }

        private bool FiltrarAutosMayoresCincoAnos(Auto auto, int limite)
        {
            int anoActual = DateTime.Now.Year;
            bool filtrado = false;

            if ((anoActual - auto.Ano) <= limite)
            {
                filtrado = true;
            }
            return filtrado;
        }

        private bool CondicionarAccionAuto(Auto autoACondicionar)
        {
            return FiltrarAutosMayoresCincoAnos(autoACondicionar, 5) && ((this.ubicacion == EUbicaicon.Ushuaia && autoACondicionar.TipoDeNieve) || this.ubicacion != EUbicaicon.Ushuaia);
        }

        public string MostrarDatosConcesionaria()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ubicacion: {this.ubicacion}");
            sb.AppendLine($"Ganancia de la Sucursal: {this.gananciaTotal.ToString("0.##")}");
            if (!string.IsNullOrEmpty(this.numeroDeTelefono))
            {
                sb.AppendLine($"Numero de Telefono: {this.numeroDeTelefono}");
            }
            sb.AppendLine($"Capacidad: {this.autos.Count}/{this.capacidadMaximaDeAutos}");
            sb.AppendLine($"Gerente: {this.nombreDeGerente}");
            sb.AppendLine($"Ganancia del Gerente: {this.gananciaDeGerente.ToString("0.##")}{Environment.NewLine}");
            sb.AppendLine("Lista de Autos");
            sb.AppendLine(MostrarListaDeAutos());

            return sb.ToString();
        }
    }
}
