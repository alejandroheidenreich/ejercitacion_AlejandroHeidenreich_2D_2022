using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Concesionaria
    {
        private string ubicacion;
        private int capacidadMaximaDeAutos;
        private string numeroDeTelefono;
        private double gananciaTotal;
        private List<Auto> autos;
        private string nombreDeGerente;
        private double gananciaDeGerente;

        public Concesionaria()
        {
            this.autos = new List<Auto>();
        }

        public Concesionaria(string ubicacion, int capacidadMaximaDeAutos, string nombreDeGerente, List<Auto> autos) :this()
        {
            this.ubicacion = ubicacion;
            this.capacidadMaximaDeAutos = capacidadMaximaDeAutos;
            this.nombreDeGerente = nombreDeGerente;
            this.autos = autos;
        }


        public string NumeroDeTelefono{
            set { this.numeroDeTelefono = value; }
        }

        public bool AgregarAuto (Auto autoAAgregar)
        {
            bool agregado = false;
            if (autoAAgregar != null && this.autos.Count < this.capacidadMaximaDeAutos)
            {
                agregado = true;
                this.autos.Add(autoAAgregar);
            }
            return agregado;
        }

        private int EncontrarAutoPorIndice(Auto autoABuscar)
        {
            int indiceDelAuto = -1;

            if (autoABuscar != null)
            {
                for (int i = 0; i < this.autos.Count; i++)
                {
                    if (this.autos[i] == autoABuscar)
                    {
                        indiceDelAuto = i;
                        break;
                    }
                }
            }
            return indiceDelAuto;
        }

        private void VenderAuto (Auto autoAVender)
        {
            int indiceDelAuto = EncontrarAutoPorIndice(autoAVender);
            double facturacion;

            if (indiceDelAuto != -1)
            {
                facturacion = autoAVender.PrecioBase;
                if (autoAVender.Importado)
                {
                    facturacion *= 1.18;
                }
                this.gananciaTotal += facturacion * .99;
                this.gananciaDeGerente = facturacion * .01;
                EliminarAuto(autoAVender);
            }
        }

        public bool EliminarAuto(Auto autoAEliminar)
        {
            bool eliminado = false;
            int indiceDelAuto = EncontrarAutoPorIndice(autoAEliminar);

            if (indiceDelAuto != -1)
            {
                this.autos.Remove(autoAEliminar);
                eliminado = true;
            }
            return eliminado;
        }

        public void MostrarListaDeAutos()
        {
            foreach (Auto item in this.autos)
            {
                Console.WriteLine(Auto.MostrarDatosDelAuto(item));
            }
        }

        public void VenderAutosMayoresCincoAnos(Auto autoAVender)
        {
            int anoActual = DateTime.Now.Year;

            if ((anoActual-autoAVender.Ano) < 6)
            {
                VenderAuto(autoAVender);
            }
        }

        public void VenderAutosConRuedasNieve(Auto autoAVender)
        {
            if ( autoAVender.TipoDeNieve)
            {
                VenderAuto(autoAVender);
            }
        }
    }
}
