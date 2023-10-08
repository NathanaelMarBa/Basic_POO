using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaria
{
    public class Bbinaria
    {
        int[] vector = new int[10];
        int[] vector1;

        public void Ingresar()
        {
            int valor = 0;
            bool bandera;
            for (int i = 0; i < vector.Length; i++)
            {
                bandera = false;
                Console.WriteLine("Ingresa un nuevo numero para el arreglo: ");
                valor = int.Parse(Console.ReadLine());
                for (int j = 0; j < vector.Length; j++)
                {
                    if (valor == vector[j])
                    {
                        bandera = true;
                    }
                }
                if (bandera == false)
                {
                    vector[i] = valor;
                }
                else
                {
                    if (i > 0)
                    {
                        Console.WriteLine("El numero introducido ya ha sido previamente ingresado, favor de volver a ingresar uno valido.");
                        i--;
                    }
                }

            }
            
            vector1 = Burbuja(vector);
            Mostrar(vector1);
        }

        public void Busqueda()
        {
            int numero, puntero = 0, final = 9, mitad = -999;
            bool bandera = false;
            Console.WriteLine("\n Que numero deseas buscar: ");
            numero = int.Parse(Console.ReadLine());
            while (bandera == false && puntero <= final)
            {
                mitad = ((puntero + final) / 2);
                if (numero == vector1[mitad])
                {
                    bandera = true;
                }
                else if (numero < vector1[mitad])
                {
                    final = mitad - 1;
                }
                else
                {
                    puntero = mitad + 1;
                }
            }
            if (bandera == true)
            {
                Console.WriteLine("Numero encontrado en la posicion: " + (mitad + 1));
            }
            else
            {
                Console.WriteLine("El numero no fue encontrado");
            }
        }

        public int[] Burbuja(int[] vector)
        {
            int t = vector.Length, temp;
            for (int i = 1; i < t; i++)
                for (int j = t - 1; j >= i; j--)
                {
                    if (vector[j] < vector[j - 1])
                    {
                        temp = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = temp;
                    }
                }
            return vector;
        }

        private void Mostrar(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " -> ");
            }
        }
    }
}
