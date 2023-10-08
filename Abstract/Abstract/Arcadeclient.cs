using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Arcadeclient
    {

        IEnemigoA enemigoA;
        IEnemigoB enemigoB;

        public Arcadeclient (IEnemigo factory)
        {
            enemigoA = factory.GetEnemigoA();
            enemigoB = factory.GetEnemigoB();
        }

        public string GetCharactersEnemya()
        {
            return enemigoA.GetEnemyCharacters();
        }

        public string GetCharactersEnemyb()
        {
            return enemigoB.GetEnemyCharacters();
        }

    }
}
