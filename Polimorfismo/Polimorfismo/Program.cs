// Susing System;
using System.Collections.Generic;
using System.Linq;

namespace Polimorfismo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Estudiante_de_primaria nazli = new Estudiante_de_primaria();
            Universitario natha = new Universitario();

            nazli.tomarlase();
            nazli.estudiar();
            natha.tomarlase();
            natha.estudiar();


        }
    }
}