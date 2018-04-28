using System;
using System.Drawing;

namespace GraficosPorTortuga
{
    class Tortuga
    {
        private Point posicion;
        private byte direccion;
        private bool estadoPluma;

        public Point Posicion
        {
            get { return posicion; }
        }

        public bool EstadoPluma 
        {
            get { return estadoPluma; }
        }

        public byte Direccion
        {
            get { return direccion; }
        }

        public Tortuga(int x, int y, byte dir)
        {
            posicion.X = x;
            posicion.Y = y;
            direccion = dir;
            estadoPluma = false;
        }

        public void Avanzar()
        {
            switch(direccion)
            {
                case 4: 
                    posicion.X--;
                    break;

                case 3: 
                    posicion.Y++;
                    break;

                case 2: 
                    posicion.X++;
                    break;

                case 1: 
                    posicion.Y--;
                    break;
            }
        }

        public void BajarPluma()
        {
            estadoPluma = true;
        }

        public void SubirPluma()
        {
            estadoPluma = false;
        }

        public void GirarDerecha()
        {
            direccion++;
            if (direccion > 4)
                direccion = 1;
        }

        public void GirarIzquierda()
        {
            direccion--;
            if (direccion < 1)
                direccion = 4;
        }

        public override string ToString()
        {
            string dir = "";
            string pos = "";

            switch(direccion)
            {
                case 1: dir = "Norte "; break;
                case 2: dir = "Este "; break;
                case 3: dir = "Sur "; break;
                case 4: dir = "Oeste "; break;
            }

            pos = "(" + posicion.X.ToString() + " ," + posicion.Y.ToString() + ")";
            
            return string.Format("estadoPluma={0} direccion={1} posicion={2}", estadoPluma ? "abajo " : "arriba ", dir, pos);
        }
    }
}