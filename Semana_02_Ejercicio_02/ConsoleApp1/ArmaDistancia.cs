using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArmaDistancia : Arma
    {
        public Proyectil Proyectil { get; set; }

        public ArmaDistancia(string nombre, int danio, int velocidadAtaque, int precio, Proyectil proyectil)
            : base(nombre, danio, velocidadAtaque, precio)
        {
            this.Proyectil = proyectil;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Proyectil: {this.Proyectil.Nombre} (Daño: {this.Proyectil.Danio})";
        }

    }
}
