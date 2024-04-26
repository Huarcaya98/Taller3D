using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_04_Actividad_01
{
    internal class Fibonacci : Numero
    {


       public Fibonacci(int n) :base(n)
        {

        }
        public override float Generar()
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine(a+" " + b+ "");

            for (int k = 3; k <= n; k++)
            {
                c = a + b;
                Console.WriteLine(c + "");

                a = b;
                b = c;


            }
            return b;


        }


    }
}
