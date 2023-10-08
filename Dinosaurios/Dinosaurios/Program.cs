using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaurios
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Dinos tabla = new Dinos();
            string opc = "0";
            int cont = 0;
            Console.WriteLine("Bienvenido al museo de dinosaurios \n");

            while (cont == 0)
            {
                if (opc != "4")
                {
                    Console.WriteLine("¿Que deseas hacer? \n1.Agregar un nuevo dinosaurio. \n2.Buscar un dinosaurio. \n3.Eliminar un dinosaurio. \n4.Salir");
                    opc = Console.ReadLine();
                    tabla.menu(opc);
                }
                else
                {
                    break;
                }
            }
        }
    }
}