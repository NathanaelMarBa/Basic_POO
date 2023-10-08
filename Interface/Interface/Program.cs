using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto kia = new Auto();
            Moto yamaha = new Moto();

            Console.WriteLine(kia.avanzar());
            Console.WriteLine(yamaha.avanzar());

            Console.ReadKey();
        }
    }
}
