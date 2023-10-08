using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, i = 0, pos = 0;
            int[] vec = { 3, 65, 2, 4, 6, 2, 6, 2, 34, 6, 345, 10, 30, 52, 5, 93, 64 };
            bool encontro = false;

            Console.WriteLine("Ingresa el numero que deseas: ");
            numero = int.Parse(Console.ReadLine());
            while (!(encontro) && i < 17)
            {
                if (numero == vec[i])
                {
                    encontro = true;
                    pos = i;
                }
                i += 1;
            }
            if (encontro)
            {
                Console.WriteLine("EL numero fue encontrado en la posición " + pos);
            }
            else
            {
                Console.WriteLine("El numero no se encontro ");
            }
            Console.ReadKey();
        }
    }
}
