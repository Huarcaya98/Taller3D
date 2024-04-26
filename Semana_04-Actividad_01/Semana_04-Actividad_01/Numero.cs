namespace Semana_04_Actividad_01
{
    internal class Numero
    {

        public int n;

        public Numero(int n)
        {
            this.n = n;
        }
        
        public virtual float Generar()
        {
            return 0;
        }

        public virtual void GenerarPrimo()
        { 
        }

        public virtual void GenerarPerfecto()
        {
        }
    }
}
