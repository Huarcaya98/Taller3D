using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_04_Actividad_01
{
    internal class Primo : Numero
    {

        public Primo(int n) : base(n)
        {

        }

        public override void GenerarPrimo()
        {
            for (int j = 2; j <= n; j++)
            {
                int cont = 0;

                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        cont = cont + 1;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine(j); // Imprimir el número primo encontrado
                }
            }
        }

    }
}

