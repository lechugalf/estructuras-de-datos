using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda2
{
    class Agenda
    {
        private Contacto[] contactos;
        private int ultimoNuevo;

        public Agenda(int N)
        { 
            contactos = new Contacto[N];
        }

        public int Agregar(Contacto nuevo)
        {
            int pos = 0;
            bool encontro = false;
            int comp = 0;

            while(pos < contactos.Length && !encontro)
            {
                if(contactos[pos] == null)
                    encontro = true;
                else
                {
                    comp = string.CompareOrdinal(nuevo.Nombre.ToLower(), contactos[pos].Nombre.ToLower());

                    if (comp < 0)
                        encontro = true;
                }

                if(!encontro)
                    pos++;        
            }

            if (encontro)
            {
                Insertar(nuevo, pos);
            }
            else
            {
                return 1;
            }
            return 0;
        }

        private void Insertar(Contacto nuevo, int pos)
        {
            for (int ct = contactos.Length - 1; ct > pos; ct--)
                contactos[ct] = contactos[ct - 1];
            contactos[pos] = nuevo;
        }

        public Contacto Buscar(string busq)
        {
            for (int ct = 0; ct < contactos.Length; ct++)
                if (contactos[ct] != null)
                    if (contactos[ct].Telefono == busq)
                        return contactos[ct];
            return null;
        }

        public void Eliminar(int pos)
        {
            for (int ct = pos; ct < contactos.Length - 1; ct++)
                contactos[ct] = contactos[ct + 1];
            contactos[contactos.Length - 1] = null;
        }

        public String Listar()
        {
            string lista = string.Format("{6, -4} {0, -20} {1, -15} {2, -15} {3, -16} {4, -7} {5, -10}",
                "Nombre", "Apellido_p", "Apellido_m", "Email", "Edad", "Telefono", "No.");
            lista += Environment.NewLine;
            int no = 0;
            foreach (Contacto contacto in contactos)
            {
                if (contacto != null)
                    lista += no.ToString() + contacto.ToString() + Environment.NewLine;
                no++;
            }
            return lista;
        }
    }
}
