using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencial
{
    public class Bsecuencial
    {
        public int[] vector;

        public void DatosRandom()
        {
            Random random = new Random();
            vector = new int[16];
            int valor;
            bool bandera = false;
            for (int i = 0; i < vector.Length; i++)
            {
                bandera = true;
                valor = random.Next(5, 21);
                for (int j = 0; j < vector.Length; j++)
                {
                    if (valor == vector[j])
                    {
                        bandera = false;
                    }
                }
                if (bandera == true)
                {
                    vector[i] = valor;
                }
                else
                {
                    if (i > 0)
                    {
                        i--;
                    };
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Estos son los elementos de tu arreglo: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " -> ");
            }
        }

        public void Busquedas()
        {
            bool bandera = false;
            int i = 0;
            Console.WriteLine("\nEscribe el numero que deseas buscar en el arreglo: ");
            int num = int.Parse(Console.ReadLine());
            while ((i < vector.Length) && bandera == false)
            {
                if (num == vector[i])
                {
                    bandera = true;
                }
                i++;
            }
            if (bandera == true)
            {
                Console.WriteLine("El numero buscado fue: " + num + " \nSe encuentra en la pocisión: " + i);
            }
            else
            {
                Console.WriteLine("El numero buscado no ha sido encontrado.");
            }

        }
    }
}
