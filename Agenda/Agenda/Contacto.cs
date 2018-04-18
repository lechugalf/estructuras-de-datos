using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contacto
    {
        private string nombre;
        private string apellido_p;
        private string apellido_m;
        private byte edad;
        private string email;
        private string telefono;

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

        public byte Edad
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
            return string.Format("{0, -25} {1, -15} {2, -15} {3, -15} {4, -5} {5, -10}",
                Nombre, Apellido_p, Apellido_m, Email, Edad, Telefono);
        }
    }
}
