using System;

namespace ListaCircular
{
    class Controlador
    {
        private Estacion estacionBase;
        //private Estacion UltimaEstacion;

        public Controlador()
        {
            
        }

        public void AgregarFinal(Estacion nuevaEstacion)
        {
            if(estacionBase != null)
            {
                nuevaEstacion.Siguiente = estacionBase;

                if(estacionBase.Siguiente == estacionBase)
                    estacionBase.Siguiente = nuevaEstacion;
                else
                {
                    Estacion pos = estacionBase.Siguiente;
                    while(pos.Siguiente != estacionBase)
                        pos = pos.Siguiente;

                    pos.Siguiente = nuevaEstacion;
                }
            }
            else
            {
                estacionBase = nuevaEstacion;
                estacionBase.Siguiente = estacionBase;
            }
            
        }

        public Estacion Buscar(string nombreEstacion)
        {
            if(estacionBase != null)
            {
                Estacion pos = estacionBase;
                do
                {
                    if(pos.Nombre == nombreEstacion)
                        return pos;

                    pos = pos.Siguiente;
                }
                while(pos.Siguiente != estacionBase);
            }
            return null;
        }

        public void EliminarPrimeraEstacion()
        {
            if(estacionBase != null)
            {
                Estacion pos = estacionBase;

                while(pos.Siguiente != estacionBase)
                    pos = pos.Siguiente;

                pos.Siguiente = pos.Siguiente.Siguiente;
                estacionBase = pos.Siguiente;
            }
        }

        public void EliminarUltimaEstacion()
        {
            if(estacionBase != null)
            {
                Estacion pos = estacionBase;

                if(estacionBase.Siguiente == estacionBase)
                {
                    estacionBase = null;
                }
                else
                {
                    while(pos.Siguiente.Siguiente != estacionBase)
                    pos = pos.Siguiente;

                    pos.Siguiente = pos.Siguiente.Siguiente;
                }
            }
        }

        public void EliminarEstacion(string nombreEstacion)
        {
            bool encontro = false;
            if(estacionBase != null)
            {
                if(estacionBase.Siguiente == estacionBase && estacionBase.Nombre == nombreEstacion)
                    estacionBase = null;
                else
                {
                    Estacion pos = estacionBase;
                
                    while(pos.Siguiente != estacionBase && !encontro)
                    {
                        if(pos.Siguiente.Nombre == nombreEstacion)
                        {
                            pos.Siguiente = pos.Siguiente.Siguiente;
                            encontro = true;
                        }       
                        pos = pos.Siguiente;
                    }
                    if(encontro == false && nombreEstacion == estacionBase.Nombre)
                    {
                        pos.Siguiente = pos.Siguiente.Siguiente;
                        estacionBase = pos.Siguiente;
                    }
                }
            }
        }
        
        public string ListarEstaciones()
        {
            string lista = "";

            if(estacionBase != null)
            {
                lista += estacionBase.ToString() + '\n'; 
                Estacion pos = estacionBase.Siguiente;

                while(pos != estacionBase)
                {
                    lista += pos.ToString() + '\n';
                    pos = pos.Siguiente;
                }
            }
            else
                lista = "no hay estaciones..";

            return lista;
        }

        public void InsertarEstacion(Estacion nuevaEstacion, int posicion)
        {
            if(estacionBase != null)
            {
                if(posicion == 0){
                    //terminar esto :v
                }
                else
                {
                    Estacion pos = estacionBase;
                    for(int p = 0; p < posicion-1; p++)
                        pos = pos.Siguiente;

                    nuevaEstacion.Siguiente = pos.Siguiente;
                    pos.Siguiente = nuevaEstacion;
                }
                
            }
        }

        public string Ruta(string nombreEstacion, int horaInicio, int horaFin)
        {
            Estacion pos = Buscar(nombreEstacion);
            int contador = 60 * horaInicio;
            string ruta = "";

            if(pos != null)
            {
                while(contador < horaFin*60)
                {
                    ruta += pos.Nombre + "  " + contador + '\n';
                    contador += pos.Siguiente.Tiempo;
                    pos = pos.Siguiente;
                }
            }

            return ruta;
        }
    }
}
