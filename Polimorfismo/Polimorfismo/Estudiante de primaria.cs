using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Estudiante_de_primaria : Estudiante
    {
        public override void estudiar()
        {
            Console.WriteLine("Estudiando español");
        }

        public override void tomarlase()
        {
           Console.WriteLine("Tomando clase de ingles");
        }
    }
}
