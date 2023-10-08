using System;
using System.Collections.Generic;
using System.Linq;

namespace Animales
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Terrestre vaca = new Terrestre("vaca",11,55,"Blanco y negro","Corto");
            Voladores canario = new Voladores("Canario", 5, 1, "Rojo","sedoso");
            Marino foca = new Marino("Foca", 10, 50, "Cafe", "Salada");

            Console.WriteLine(vaca.nombre + " " + vaca.tamaño + " " + vaca.peso + " " + vaca.pelaje + " " + vaca.color);
            Console.WriteLine(canario.nombre + " " + canario.tamaño + " " + canario.peso + " " + canario.plumaje + " " + canario.color);
            Console.WriteLine(foca.nombre + " " + foca.tamaño + " " + foca.peso + " " + foca.tipodeagua + " " + foca.color);
        }
    }
}