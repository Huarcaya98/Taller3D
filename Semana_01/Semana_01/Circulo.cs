using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01
{
    internal class Circulo : Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override float CalcularArea()
        {
            return (float)(Math.PI * Math.Pow(radio, 2));
        }

    }
}
