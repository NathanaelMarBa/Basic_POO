using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Papa
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string piel { get ; set; }

        public Papa(string nombre, int edad, string piel)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.piel = piel;
        }

        public string trabajo()
        {
            return (this.nombre + " Esta en el trabajo");
        }
    }
}
