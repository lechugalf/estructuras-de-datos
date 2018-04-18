using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        byte nuevo;
        private Contacto[] contactos;

        public byte Nuevo { get { return nuevo; } }
        public int Len { get { return contactos.Length; } }
        public Contacto Contactos(int pos)
        {
            return contactos[pos];
        }

        public Agenda(int n)
        {
            contactos = new Contacto[n];

            //inicializa contactos
            for (int con = 0; con < n; con++)
                contactos[con] = new Contacto();

            //posicionamos el registro para agregar en cero
            nuevo = 0;
        }

        public void Insertar(Contacto ncontacto, byte pos)
        {
            //recorremos los contactos a la derecha para insertar
            //un nuevo contacto
            if (Recorrer(pos, 'd'))
            {
                contactos[pos] = ncontacto;
                nuevo++;
            }
        }

        public void Agregar(Contacto ncontacto)
        {
            if(nuevo < contactos.Length)
            {
                contactos[nuevo] = ncontacto;
                nuevo++;
            }
        }

        private bool Recorrer(byte pos, char dir)
        {
            //recorre los elemento de nuestro vector desde una
            //posicion y hacia una direccion dada, solo si hay espacio.

            if (dir == 'd') //recorre hacia la derecha
                if (nuevo < contactos.Length)
                {
                    for (int con = contactos.Length - 1; con > pos; con--)
                        contactos[con] = contactos[con - 1];
                    return true;
                }
                else
                    return false;

            if (dir == 'i') //recorre hacia la izquierda
                if (pos == contactos.Length - 1)
                    return false;
                else
                {
                    for (int con = pos; con < contactos.Length - 1; con++)
                        contactos[con] = contactos[con + 1];
                    return true;
                }

            return false;
        }

        public int Buscar(string busqueda)
        {
            //recorre todos los contactos
            int i = 0;
            foreach (Contacto contacto in contactos)
            {
                //valida el telefono de cada contacto con la busqueda
                if (contacto.Telefono == busqueda)
                    return i;
                i++;
            }

            //si no encuentra ningun contacto regresa null
            return -1;
        }

        public void Eliminar(byte pos)
        {
            //recorrer los contacots hacia la izquierda
            //borrando el contacto en la posicion dada
            if (Recorrer(pos, 'i'))
                nuevo--;
        }

        public string Listar()
        {
            string lista = string.Format("{0, -25} {1, -15} {2, -15} {3, -15} {4, -5} {5, -10}",
                "Nombre", "Apellido Pat", "Apellido Mat", "Email", "Edad", "Telefono");
            lista += Environment.NewLine;
            foreach (Contacto contacto in contactos)
                lista += contacto.ToString() + Environment.NewLine;

            return lista;
        }
    }
}
