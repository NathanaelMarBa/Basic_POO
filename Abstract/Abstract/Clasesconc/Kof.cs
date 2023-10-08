using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
     class Kof : IEnemigo
    {
        public IEnemigoA GetEnemigoA()
        {
            return new orochi();
        }

        public IEnemigoB GetEnemigoB()
        {
            return new rugal();
        }
    }
}
