﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pistola : ArmaDistancia
    {
        public Pistola(string nombre, int danio, int velocidadAtaque, int precio, Proyectil proyectil)
        : base(nombre, danio, velocidadAtaque, precio, proyectil)
        {
        }

    }
}
