using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeTransporte
{
    internal class Bicicleta : Transporte
    {
        public Bicicleta(string nombre, double peso, double velocidad)
        {
            this.nombre = nombre;
            energia = "Esfuerzo";
            this.peso = peso;
            this.velocidad = velocidad;
        }

        public override void moverse()
        {
            Console.WriteLine("Pedaleando con " + energia);
        }
    }
}
