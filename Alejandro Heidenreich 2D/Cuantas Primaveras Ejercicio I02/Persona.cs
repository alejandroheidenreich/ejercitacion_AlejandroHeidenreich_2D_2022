using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuantas_Primaveras_Ejercicio_I02
{
    internal class Persona
    {
        public string nombre;
        public DateTime fechaDeNacimiento;
        public string dni;

        public Persona(string nombre, int dia, int mes, int año, string dni)
        {
            this.nombre = nombre;
            SetNacimiento(dia, mes, año);
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetNacimiento()
        {
            return this.fechaDeNacimiento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture); ;
        }

        public string GetDNI()
        {
            return this.dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNacimiento(int dia, int mes, int año)
        {
            DateTime fecha = new DateTime(año, mes, dia);

            this.fechaDeNacimiento = fecha;
        }

        public void SetDNI(string dni)
        {
            this.dni = dni;
        }

        public int CalcularEdad()
        {
            int edad;
            edad = DateTime.Now.Year - this.fechaDeNacimiento.Year;
            if (this.fechaDeNacimiento.Date > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public string MostrarPersona()
        {
            return $"{GetNombre()}\n{GetNacimiento()}\n{GetDNI()}";
        }

        public string EsmayorDeEdad()
        {
            string respuesta = "Es mayor de edad";
            if (this.CalcularEdad() < 17)
            {
                respuesta = "Es menor";
            }

            return respuesta;
        }
    }
}
