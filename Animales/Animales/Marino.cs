using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Marino : Animal
    {
        public String tipodeagua { get; set; }

        public Marino(string nombre, int tamaño, int peso, string color, string tipodeagua) : base(nombre, tamaño, peso, color)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.peso = peso;
            this.color = color;
            this.tipodeagua = tipodeagua;
        }
    }
}
