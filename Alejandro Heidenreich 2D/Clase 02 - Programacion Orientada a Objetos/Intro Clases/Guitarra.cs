using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Clases
{
    public class Guitarra
    {
        // atributos SUSTANTIVOS SINGULARES
        public string marca;
        public int precio;
        public string material;

        public Guitarra(string marca, int precio, string material)
        {
            this.marca = marca;
            this.precio = precio;
            this.material = material;
        }

        // comportamientos VERBOS

        public void SubirDePrecio (int aumento = 2) // parametro opcional
        {
            precio *= aumento;
        }

    }
}
