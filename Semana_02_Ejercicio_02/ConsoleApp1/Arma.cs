using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arma
    {
        public string Nombre { get; set; }
        public int Danio { get; set; }
        public int VelocidadAtaque { get; set; }
        public int Precio { get; set; }

        public Arma(string nombre, int danio, int velocidadAtaque, int precio)
        {
            this.Nombre = nombre;
            this.Danio = danio;
            this.VelocidadAtaque = velocidadAtaque; 
            this.Precio = precio;

        }

        public float CalcularDPS()
        {
            return this.Danio / (float)this.VelocidadAtaque ;
        }

        public override string ToString()
        {
            return $"{this.Nombre } - DañoxSegundo{CalcularDPS() } - Precio {this.Precio }";
        }


    }
}
