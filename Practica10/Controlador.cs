using System;

namespace ListaCircular
{
    class Controlador
    {
        private Estacion estacionBase;
        private Estacion UltimaEstacion;

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

        public void EliminarUltimaEstacion()
        {

        }

        public void EliminarPrimeraEstacion()
        {

        }

        public void EliminarEstacion(string nombreEstacion)
        {
            
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

        public void InsertarEstacion(Estacion nuevaEstacion, int pos)
        {

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
