using System;

namespace LiebreTortuga
{
    abstract class Corredor
    {
        protected static Random rand = new Random(); 
        protected int pasos;
        private string nombre;

        public Corredor(string nombre)
        {
            this.nombre = nombre;
        }

        public int Pasos { get{ return pasos; } }
        public string Nombre { get{ return nombre; }}
        public virtual void correr() {}
    }
}