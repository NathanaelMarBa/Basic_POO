using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematicas calculadora = new Matematicas();

            int n1, n2;

            Console.WriteLine("Ingresa un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un segundo numero");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(calculadora.suma(n1, n2));
            Console.WriteLine(calculadora.resta(n1, n2));
            Console.WriteLine(calculadora.multiplicacion(n1, n2));
            Console.WriteLine(calculadora.division(n1, n2));

            Console.ReadKey();



        }
    }
}
