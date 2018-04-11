﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    class Marciano:Guerrero
    {
        private static int cuantosVivos = 0;
        public int CuantosVivos { get { return cuantosVivos; } }

        public Marciano(string nombre)
            :base(nombre)
        {
            cuantosVivos++;
        }

        public void recibirDisparo(int disparo)
        {
            if(estaVivo && blanco == disparo)
            {
                estaVivo = false;
                cuantosVivos--;
            }
        }
    }
}
