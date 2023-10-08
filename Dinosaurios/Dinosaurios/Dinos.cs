using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaurios
{
    internal class Dinos
    {

        Hashtable htbl = new Hashtable();

        public void añadir()
        {
            int cont = -1;
            string producto, clave;

            Console.WriteLine("Ingresa el nombre del dinosaurio \n");
            producto = Console.ReadLine();
            cont = cont + 1;
            if (producto != null)
            {
                clave = ("DN" + 0 + htbl.Count);
                htbl.Add(clave, producto);
                Console.WriteLine("\n Se registro el dinosaurio " + producto + " " + "Con la clave " + clave + "\n");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Por favor ingresa el nombre del dinosaurio \n");
            }
        }

        public void mostrar()
        {
            string clave;
            Console.WriteLine("Existen {0} dinosaurios en el museo, ingresa la clave del dinosaurio que deseas ver \n", htbl.Count);
            clave = Console.ReadLine();
            if (htbl[clave] != null)
            {
                Console.WriteLine("El dinosaurio es: " + htbl[clave] + "\n");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Este dinosaurio no existe, asegurate de que escribiste bien su clave \n");
                Console.ReadKey();
            }
        }

        public void eliminar()
        {
            string clave;
            Console.WriteLine("Ingresa la clave del dinosaurio a eliminar \n");
            clave = Console.ReadLine();

            if (htbl[clave] != null)
            {
                htbl.Remove(clave);
                Console.WriteLine("El dinosaurio fue eliminado de manera exitosa");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El dinosaurio especificado no fue encontrado, verifica su clave");
            }
        }

        public void menu(string opc)
        {
            switch (opc)
            {
                case "1":
                    añadir();
                    break;
                case "2":
                    mostrar();
                    break;
                case "3":
                    eliminar();
                    break;
                case "4":
                    Console.WriteLine("Hasta pronto");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}

