using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Hijo : Papa
    {
        public string ocupacion { get; set; }

        public Hijo(string nombre, int edad, string piel, string ocupacion) : base(nombre, edad, piel)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.piel = piel;
            this.ocupacion = ocupacion;
        }
    }
}
