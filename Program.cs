using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clas3Poo20defeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es la marca del vehiculo");
            string marca = Console.ReadLine();
            Console.WriteLine("cual es el modelo del vehiculo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Cual es el cilindraje del vehiculo");
            string cilindraje = Console.ReadLine();

            Console.WriteLine("Cual es el precio del vehiculo");
            double precio = double.Parse(Console.ReadLine());


            Vehiculo vehiculo = new Vehiculo(marca, modelo, cilindraje, precio);
            Vehiculo mivehiculo = new  Vehiculo();


            Console.WriteLine("\n\n\t\tMarca: " + vehiculo.Marca);
            Console.WriteLine("\t\tModelo: " + vehiculo.Modelo);
            Console.WriteLine("\t\tCilindraje: " + vehiculo.Cilindraje);
            Console.WriteLine("\t\tPrecio: " + vehiculo.Precio);
            mivehiculo.Mostrar();

            Console.ReadKey();
        }
    }
}
