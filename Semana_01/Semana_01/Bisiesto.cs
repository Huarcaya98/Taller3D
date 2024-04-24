using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01
{
    internal class Bisiesto
    {
        private int anio;

        public  Bisiesto(int anio)
        {
            this.anio = anio;
        }

        public string ResultadoBisiesto()
        {
            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        return "El año " + anio + " es bisiesto.";
                    }
                    else
                    {
                        return "El año " + anio + " no es bisiesto.";
                    }
                }
                else
                { 
                    return "El año " + anio + " es bisiesto.";
                }
            }
            else
            {
                return "El año " + anio + " no es bisiesto.";
            }
        }
    }

    }

