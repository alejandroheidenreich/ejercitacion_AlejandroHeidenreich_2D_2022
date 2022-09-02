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
        private Gerente gerenteDeSucursal;

        public Concesionaria()
        {
            this.autos = new List<Auto>();
        }
        public Concesionaria(string ubicacion, int capacidadMaximaDeAutos, Gerente gerente):this()
        {
            this.ubicacion = ubicacion;
            this.capacidadMaximaDeAutos = capacidadMaximaDeAutos;
            this.gerenteDeSucursal = gerente;
        }
        public Concesionaria(string ubicacion, int capacidadMaximaDeAutos, Gerente gerente, string numeroDeTelefono, List<Auto> autos) :this(ubicacion,capacidadMaximaDeAutos,gerente)
        {
            this.numeroDeTelefono = numeroDeTelefono;
            this.autos = autos;
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
        public void VenderAuto (Auto autoAVender)
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
                this.gerenteDeSucursal.Ganacia = facturacion * .01;
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
    }
}
