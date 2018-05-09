using System;

namespace AgendaListasEnlazadas
{
    class Agenda
    {
        Contacto contacto;

        public Agenda()
        {
            
        }

        public void Agregar(Contacto nuevo)
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

        public void Insertar(int pos, Contacto nuevo)
        {
            int cont = 0;
            Contacto cpos = contacto;

            for(cont = 0; cont < pos-1; cont++)
                cpos = cpos.Siguiente;

            if(cpos != null)
            {
                nuevo.Siguiente = cpos.Siguiente;
                cpos.Siguiente = nuevo;
            }
        }

        public int Eliminar(string telefono)
        {
            bool encontrado = false;
            Contacto pos = contacto;

            if(pos != null)
            {
                if(pos.Telefono == telefono)
                {
                    contacto = pos.Siguiente;
                    return 0;
                }

                while(pos.Siguiente != null && !encontrado)
                {
                    if(pos.Siguiente.Telefono == telefono)
                        encontrado = true;
                    else
                        pos = pos.Siguiente;
                }
            }

            if(encontrado)
            {
                pos.Siguiente = pos.Siguiente.Siguiente;
                return 0;
            }
            return 1;
        }

        public string Listar()
        {
            string lista = "";
            if(contacto == null)
                return "Agenda vacia!";
            else
            {
                Contacto pos = contacto;
                int cont = 0;

                while(pos != null)
                {
                    lista += cont.ToString() + pos.ToString() + '\n';
                    cont++;
                    pos = pos.Siguiente;
                }
                
            }
            return lista;
        }


    }
}