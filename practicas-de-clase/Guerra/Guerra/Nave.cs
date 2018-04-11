using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    class Nave
    {
        private Guerrero[] tripulacion = new Guerrero[10];
        private string tipo;

        public Nave(string tipo)
        {
            this.tipo = tipo;
            if (tipo == "Terricola")
                for (int i = 0; i < 10; i++)
                    tripulacion[i] = new Terricola("T: " + (i + 1));
            else
                for (int i = 0; i < 10; i++)
                    tripulacion[i] = new Marciano("M: " + (i + 1));
        }

        public int disparar(int turno)
        {
            return tripulacion[turno].disparar();
        }

        public void recibirDisparo(int disparo)
        {
            if (tipo == "Terricola")
                foreach(Guerrero g in tripulacion)
                {
                    Terricola t = (Terricola)g;
                    t.recibirDisparo(disparo);
                }

            if (tipo == "Marciana")
                foreach (Guerrero g in tripulacion)
                {
                    Marciano m = (Marciano)g;
                    m.recibirDisparo(disparo);
                }
        }

        public int cuantosQuedan()
        {
            if (tipo == "Marciana")
                return ((Marciano)tripulacion[1]).CuantosVivos;
            else
                return ((Terricola)tripulacion[1]).CuantosVivos;
        }
    }
}
