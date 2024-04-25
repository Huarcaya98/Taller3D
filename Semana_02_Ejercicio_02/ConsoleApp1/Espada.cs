using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Espada : Arma
    {

        public Espada(string nombre, int danio, int velocidadAtaque, int precio)
        : base(nombre, danio, velocidadAtaque, precio)
        {
        }

    }
}
