using Abstract.Clasesconc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludo saludar = new Saludo();

            saludar.saludar();

            IEnemigo kof = new Kof();
            Arcadeclient retro = new Arcadeclient(kof);

            Console.WriteLine("***** Kink of figthers *****" + "\n");
            Console.WriteLine("Caracteristicas de Orochi: " + retro.GetCharactersEnemya() + "\n");
            Console.WriteLine("Caracteristicas de Rugal: " + retro.GetCharactersEnemyb() + "\n");

            IEnemigo streetf = new Streetf();
            Arcadeclient retro2 = new Arcadeclient(streetf);

            Console.WriteLine("***** Street Figther *****" + "\n");
            Console.WriteLine("Caracteristicas de Akuma: " + retro2.GetCharactersEnemya() + "\n");
            Console.WriteLine("Caracteristicas de Bision: " + retro2.GetCharactersEnemyb() + "\n");

            IEnemigo mk = new MK();
            Arcadeclient retro3 = new Arcadeclient(mk);

            Console.WriteLine("***** Mortal Kombat *****" + "\n");
            Console.WriteLine("Caracteristicas de Shinnok: " + retro3.GetCharactersEnemya() + "\n");
            Console.WriteLine("Caracteristicas de Shao Kahn: " + retro3.GetCharactersEnemyb() + "\n");

            Console.ReadKey();
        }
    }
}
