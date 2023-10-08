using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Htable tabla = new Htable();
            string opc = "0";
            int cont = 0;
            Console.WriteLine("Bienvenido A suplementos Nathan´s, \n");

            while (cont == 0)
            {
                if(opc != "4")
                {
                    Console.WriteLine(" ¿Que deseas hacer? \n 1.Agregar un nuevo producto. \n 2.Buscar un producto. \n 3.Eliminar un producto. \n 4.Salir");
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
