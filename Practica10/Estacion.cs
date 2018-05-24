using System;

namespace ListaCircular
{
    class Estacion
    {
        private int tiempo;
        private string nombre;
        private Estacion siguiente;

        public Estacion(){}

        public Estacion(int tiempo, string nombre, Estacion siguiente)
        {
            this.tiempo = tiempo;
            this.nombre = nombre;
            this.siguiente = siguiente;
        }

        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

        public Estacion Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return string.Format("{0, -4} {1, -12} {2, -4}m",null, nombre, tiempo);
        }
    }
}
