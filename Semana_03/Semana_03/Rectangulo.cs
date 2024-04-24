﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_03
{
    internal class Rectangulo : Figura
    {
        private float baseRectangulo;
        private float alturaRectangulo;

        public Rectangulo(float baseRectangulo, float alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public override float CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }

    }
}
