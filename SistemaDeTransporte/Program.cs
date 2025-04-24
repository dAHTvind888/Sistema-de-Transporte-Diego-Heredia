using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeTransporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Auto Suzuki", 200, 80);
            Bicicleta bicicleta = new Bicicleta("Super Bicicleta", 15, 35);
            Scooter scooter = new Scooter("Small Scooter", 8, 20);

            Console.WriteLine("1." + auto.Nombre);
            Console.WriteLine("2." + bicicleta.Nombre);
            Console.WriteLine("3." + scooter.Nombre);
            Console.WriteLine("4. Encender todos los vehiculos");
            Console.WriteLine("5. Salir");
            string numerovehiculoSeleccionado = Console.ReadLine();

            while(numerovehiculoSeleccionado != "5")
            {
                if (numerovehiculoSeleccionado == "1")
                {
                    auto.moverse();
                }
                else if (numerovehiculoSeleccionado == "2")
                {
                    bicicleta.moverse();
                }
                else if (numerovehiculoSeleccionado == "3")
                {
                    scooter.moverse();
                }
                else if (numerovehiculoSeleccionado == "4")
                {
                    auto.moverse();
                    bicicleta.moverse();
                    scooter.moverse();
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
                Console.WriteLine("1." + auto.Nombre);
                Console.WriteLine("2." + bicicleta.Nombre);
                Console.WriteLine("3." + scooter.Nombre);
                Console.WriteLine("4. Encender todos los vehiculos");
                Console.WriteLine("5. Salir");
                numerovehiculoSeleccionado = Console.ReadLine();
            }
        }
    }
}
