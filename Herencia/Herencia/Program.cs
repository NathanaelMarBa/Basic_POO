using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Papa Tomas = new Papa("Tomas", 40, "Moreno");
            Hijo Nathanael = new Hijo("Nathanael", 19, "Moreno", "Estudiante");

            Console.WriteLine(Nathanael.trabajo());

            Console.ReadKey();
        }
    }
}
