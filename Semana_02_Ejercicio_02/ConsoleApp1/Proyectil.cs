using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Proyectil
    {

        public string Nombre { get; set; }
        public int Danio { get; set; }

        public Proyectil(string nombre, int danio)
        {
            this.Nombre = nombre;
            this.Danio = danio;
        }
    }
}
