using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clas3Poo20defeb
{
    internal class Vehiculo
    {
        string marca;
        string modelo;
        string cilindraje;
        double precio;

        public Vehiculo(string marca, string modelo, string cilindraje, double precio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cilindraje = cilindraje;
            this.Precio = precio;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cilindraje { get => cilindraje; set => cilindraje = value; }
        public double Precio { get => precio; set => precio = value; }

        public Vehiculo() 
        {

        }

        public void Mostrar()
        {
            Console.WriteLine("Estoy en el metodo mostrar de la clase vehículo");
        }
    }
}
