using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeTransporte
{
    internal class Transporte
    {
        protected string nombre;
        protected string energia;
        protected double peso;
        protected double velocidad;

        public virtual void moverse()
        {
            Console.WriteLine("Moviendose");
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Energia
        {
            get { return energia; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }
    }
}
