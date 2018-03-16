using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCarrera
{
    class Corredor
    {
        private string nombre;
        private int pasos;
        private Random rand;

        public Corredor(string nombre, int semilla)
        {
            this.nombre = nombre;
            this.pasos = 0;
            this.rand = new Random(semilla);
        }

        public void Correr()
        {
            bool pasa = false;
            while (!pasa)
            {
                switch (rand.Next(101))
                {
                    case 50: pasos += 2; pasa = true; break;
                    case 20: pasos += 3; pasa = true; break;
                    case 30: pasos += 1; pasa = true; break;
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public int Pasos
        {
            get { return pasos; }
        }
    }
}
