using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Animal
    {
        public string nombre { get; set; }
        public int tamaño { get; set; }
        public int peso { get; set; }
        public string color { get; set; }

        public Animal(string nombre, int tamaño, int peso, string color)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.peso = peso;
            this.color = color;
        }
    }
}
