/*Ejercicio Concesionaria 

Una concesionaria de autos necesita crear un sistema para poder manejar las ventas de sus autos. 
Esta concesionaría tiene dos sucursales manejadas por dos gerentes y con un stock de autos diferentes.
La primera sucursal está ubicada en Buenos Aires, tiene tan solo 10 autos en el salón, pero tiene lugar para recibir 5 autos más, y su gerente es el sr Pepe Peposo desde hace 10 años.
La segunda sucursal está ubicada en Ushuaia, su número de teléfono es 638-0465, tiene capacidad para 20 autos y no tiene más lugares libres.
A esta última concesionaria la lidera desde hace 5 la señorita Carola Perrosa de 35 años de edad. 
Todos los autos que se venden ya son patentados, algunos son nuevos y otros usados (no venden ni aceptan autos para vender con antigüedad mayor a 5 años) y en la sucursal de Ushuaia aceptan solo autos con ruedas para nieve por el momento. 
Aquellos autos que son importados aumentarán su precio de venta un 18% por encima de su precio base.
La ganancia de la concesionaria se calculará en base a las ventas de los autos que se hayan realizado, y el gerente recibirá como bono el 1% de esa ganancia.

Preguntas funcionales: 
¿Cuáles clases reconoce? 
Consecionaria, Auto, Gerente

¿Qué atributos tiene cada clase? 
Concesionaria:
    string ubicacion
    int capacidadMaximaDeAutos
    string numeroDeTelefono
    double gananciaTotal
    List<Auto> autos
    Gerente gerenteDeSucursal

Auto:
    EMarca marca
    string modelo
    string patente
    ConsoleColor color
    bool importado
    double precioBas
    bool tipoDeNieve
    int año

Gerente:
    string nombre
    int edad
    int antiguedad
    double ganancia

¿Hay algún tipo de relación entre las clases? 
Si, concesionaria necesita un objeto Gerente y un array/lista de objetos Auto
*/

using System;

namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concesionaria sucursalBuenosAires = new Concesionaria();
            Concesionaria sucursalUshuaia = new Concesionaria();

        }
    }
}
