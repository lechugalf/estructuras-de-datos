using System;

namespace Practica9
{
    class Contacto
    {

        private Contacto siguiente;
        private Contacto anterior;

        private string nombre;
        private string apellido_p;
        private string apellido_m;
        private string edad;
        private string email;
        private string telefono;

        public Contacto(string nombre, string apellido_p, string apellido_m,
            string edad, string email, string telefono)
        {
            this.nombre = nombre;
            this.apellido_p = apellido_p;
            this.apellido_m = apellido_m;
            this.edad = edad;
            this.email = email;
            this.telefono = telefono;
        }

        public Contacto() { }

        public Contacto Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Contacto anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido_p
        {
            get { return apellido_p; }
            set { apellido_p = value; }
        }

        public string Apellido_m
        {
            get { return apellido_m; }
            set { apellido_m = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public override string ToString()
        {
            return string.Format("{6, -4} {0, -20} {1, -15} {2, -15} {3, -18} {4, -8} {5, -15}",
                Nombre, Apellido_p, Apellido_m, Email, Edad, Telefono, null);
        }
    }
}