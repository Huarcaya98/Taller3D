using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_04_Actividad_01
{
    internal class Perfecto : Numero
    {
        public Perfecto(int n) : base(n)
        {

        }

        public override void GenerarPerfecto()
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine($"{i} : Es un número perfecto");
                }
            }
        }

    }
}
