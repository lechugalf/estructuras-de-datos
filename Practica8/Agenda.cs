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
            if(pos == 0)
            {
                AgregarInicio(nuevo);
            }
            else
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
            
        }

        public Contacto Buscar(string busq)
        {

            Contacto pos = contacto;

            if(pos != null)
            {
                if(pos.Telefono == busq)
                    return pos;

                while(pos.Siguiente != null)
                {
                    if(pos.Siguiente.Telefono == busq)
                        return pos;
                    else
                        pos = pos.Siguiente;
                }
            }
            return null;
        }
        public int Eliminar(string telefono)
        {
            Contacto pos = Buscar(telefono);
            if(pos.Siguiente != null)
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

        public void AgregarInicio(Contacto nuevo)
        {
            nuevo.Siguiente = contacto;
            contacto = nuevo;
        }
        public void EliminarInicio()
        {
            contacto = contacto.Siguiente;
        }
        public void EliminarUltimo()
        {
            Contacto pos = contacto;

            if(pos != null)
            {
                while(pos.Siguiente.Siguiente != null)
                        pos = pos.Siguiente;

                pos.Siguiente = null;
            }
        }
        public string ListarInverso()
        {
            Contacto pos = contacto;
            string result = "";

            if(pos == null)
                result = "Agenda vacia!";
            else
            {
                while(pos != null){
                    result = pos.ToString() + '\n' + result;
                    pos = pos.Siguiente;
                }
            }
            return result;
        }

        public void Invertir()
        {
            
        }
    }
}