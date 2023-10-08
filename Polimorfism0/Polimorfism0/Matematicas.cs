using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism0
{
    public  class Matematicas
    {

        public int suma(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;

            return resultado;
        }

        public int resta(int num1, int num2)
        {
            int resultado;
            resultado = num1 - num2;

            return resultado;
        }

        public int multiplicacion(int num1, int num2)
        {
            int resultado;
            resultado = num1 * num2;

            return resultado;
        }

        public int division(int num1, int num2)
        {
            int resultado;
            resultado = num1 / num2;

            return resultado;
        }
    }
}
