using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    abstract class Guerrero : SerVivo
    {
        private static Random rand = new Random();
        protected int blanco;
        protected string nombre;

        public string Nombre{ get{ return nombre; } }
        public Guerrero(string nombre)
        {
            this.nombre = nombre;
            this.blanco = rand.Next(10);
        }

        public int disparar()
        {
            if (estaVivo)
                return rand.Next(10);
            else
                return 10;      
        }
    }
}
