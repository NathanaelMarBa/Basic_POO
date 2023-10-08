using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Universitario : Estudiante
    {

        public override void estudiar()
        {
            Console.WriteLine("Estdiando Ingles");
        }

        public override void tomarlase()
        {
            Console.WriteLine("El estudiante esta en clase de programacion");
        }
    }
}
