using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Saludo : Claseabs
    {
        override public void saludar()
        {
            Console.WriteLine("Hola, Bienvenido a los Arcades" + "\n");
        }
    }
}
