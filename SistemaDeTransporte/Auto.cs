using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeTransporte
{
    internal class Auto : Transporte
    {

        public Auto(string nombre, double peso, double velocidad)
        {
            this.nombre = nombre;
            energia = "Gasolina";
            this.peso = peso;
            this.velocidad = velocidad;
        }


        public override void moverse()
        {
            Console.WriteLine("Conduciendo usando " + energia);
        }
    }
}
