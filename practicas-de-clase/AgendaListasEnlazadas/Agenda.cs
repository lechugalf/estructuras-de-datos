using System;

namespace AgendaListasEnlazadas
{
    class Agenda
    {
        Contacto contacto;

        public Agenda(int N)
        {
            contacto = new Contacto();
        }

        public Agregar(Contacto nuevo)
        {
            if(contacto == null)
                contacto = nuevo;

            else
            {
                Contacto pos = contacto;

                while(pos.Siguiente != null)
                    pos = pos.Siguiente;

                pos.Siguiente = nuevo;
            }
        }

        public Insertar(int pos, Contacto nuevo)
        {
            int cont = 0;
            Contacto pos = contacto;

            for(cont = 0; cont <= pos; cont++)
                pos = pos.Siguiente;

            if(pos != null)
            {
                nuevo.Siguiente = pos.Siguiente;
                pos.Siguiente = nuevo;
            }
        }

        public Eliminar(string telefono)
        {
            Contacto pos = contacto;
            bool encontrado = false;
            while(pos.Siguiente != null)
            {
                if(pos.Siguiente.Telefono == telefono)
                    encontrado = true;
                pos = pos.Siguiente;
            }
            if(encontrado)
                pos.Siguiente = pos.Siguiente.Siguiente;
        }

        public Listar()
        {
            string lista = "";
            if(contacto == null)
                return lista;
            else
            {
                Contacto pos = contacto;
                int cont = 0;
                while(pos.Siguiente != null)
                {
                    lista += cont.ToString() + pos.ToString() + '\n';
                    cont++;
                }
            }
            return lista;
        }


    }
}