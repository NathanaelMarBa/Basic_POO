using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bsecuencial vector = new Bsecuencial();
            vector.DatosRandom();
            vector.Mostrar();
            vector.Busquedas();
            Console.ReadKey();
        }
    }
}
