using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeTransporte
{
    internal class Scooter : Transporte
    {

        public Scooter(string nombre, double peso, double velocidad)
        {
            this.nombre = nombre;
            energia = "Bateria Electrica";
            this.peso = peso;
            this.velocidad = velocidad;
        }

        public override void moverse()
        {
            Console.WriteLine("Avanzando con " + energia);
        }
    }
}
