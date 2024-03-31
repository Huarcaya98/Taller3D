using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01
{
    internal class Triangulo : Figura
    {
        private float baseTriangulo;
        private float alturaTriangulo;

        public Triangulo(float baseTriangulo, float alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override float CalcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
