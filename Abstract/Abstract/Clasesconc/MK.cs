using Abstract.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Clasesconc
{
    class MK : IEnemigo
    {
        public IEnemigoA GetEnemigoA()
        {
            return new shinnok();
        }

        public IEnemigoB GetEnemigoB()
        {
            return new Shao_Kahn();
        }

    }
}
