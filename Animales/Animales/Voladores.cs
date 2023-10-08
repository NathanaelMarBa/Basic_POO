using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Voladores : Animal
    {

        public string plumaje { get; set; }
        public Voladores(string nombre, int tamaño, int peso, string color, string plumaje) : base(nombre,tamaño, peso, color)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.peso = peso;
            this.color = color;
            this.plumaje = plumaje;
        }

    }
}
