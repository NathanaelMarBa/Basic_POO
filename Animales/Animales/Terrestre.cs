using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Terrestre : Animal
    {
        public string pelaje { get; set; }

        public Terrestre(string nombre, int tamaño, int peso, string color, string pelaje) : base(nombre, tamaño, peso, color)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.peso = peso;
            this.color = color;
            this.pelaje = pelaje;
        }
    }
}
