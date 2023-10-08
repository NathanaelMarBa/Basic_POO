using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Streetf : IEnemigo
    {
        public IEnemigoA GetEnemigoA()
        {
            return new akuma();
        }

        public IEnemigoB GetEnemigoB()
        {
            return new bision();
        }
    }
}
