using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo_Ejercicio_I01
{
    public class Cuenta
    {
        public string titular;
        public double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public string MostrarCuenta()
        {
            return $"Cuenta\nTitular: {GetTitular()}\nCantidad: ${GetCantidad().ToString("N2")}";
        }
        
        public void IngresarMontoACuenta(double cantidadIngresada)
        {
            if (cantidadIngresada > 0)
            {
                this.cantidad+=cantidadIngresada;
            }
        }

        public void RetirarMontoDeCuenta(double cantidadIngresada)
        {
            if (cantidadIngresada > 0)
            {
                this.cantidad -= cantidadIngresada;
            }
        }
    }
}
