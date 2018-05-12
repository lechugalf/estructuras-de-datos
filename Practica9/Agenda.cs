using System;

namespace Practica9
{
    class Agenda
    {
        Contacto contacto;

        public void Agregar(Contacto nuevo)
        {
            if(contacto == null)
                contacto = nuevo;
            else
            {
                Contacto pos = contacto;
                bool agregado = false;
                while(!agregado)
                {
                    if(String.Compare(nuevo.Nombre, pos.Nombre, true) <= 0)
                    {
                        if(pos.Anterior == null)
                        {
                            nuevo.Siguiente = pos;
                            pos.Anterior = nuevo;
                            contacto = nuevo;
                            agregado = true;

                        }
                        else
                        {
                            nuevo.Anterior = pos.Anterior;
                            nuevo.Siguiente = pos;
                            nuevo.Anterior.Siguiente = nuevo;
                            pos.Anterior = nuevo;
                            agregado = true;
                        }
                    }
                    else if(pos.Siguiente == null)
                    {
                        pos.Siguiente = nuevo;
                        nuevo.Anterior = pos;
                        agregado = true;
                    }
                    pos = pos.Siguiente;
                }
            }
        }

        public Contacto Buscar(string nombre)
        {

            Contacto pos = contacto;
            bool fuera = false;

            while(pos != null && !fuera)
            {
                if(String.Compare(nombre, pos.Nombre, true) < 0)
                    fuera = true;

                else if(pos.Nombre == nombre)
                    return pos;

                else
                    pos = pos.Siguiente;
            }

            return null;
        }
        public int Eliminar(string nombre)
        {
            Contacto pos = Buscar(nombre);
            if(pos != null)
            {
                if(pos.Anterior == null && pos.Siguiente == null)
                {
                    contacto = null;
                    return 0;
                }
                else if(pos.Anterior == null && pos.Siguiente != null)
                {
                    pos.Siguiente.Anterior = null;
                    contacto = pos.Siguiente;
                    return 0;
                }
                else if(pos.Anterior != null && pos.Siguiente == null)
                {
                    pos.Anterior.Siguiente = null;
                    return 0;
                }
                else 
                {
                    pos.Anterior.Siguiente = pos.Siguiente;
                    pos.Siguiente.Anterior = pos.Anterior;
                    return 0;
                }
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
    }
}