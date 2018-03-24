using System;

namespace LiebreTortuga
{
    class Carrera
    {
        private Corredor compet1, compet2;
        private string ganador;

        public Carrera(Corredor c1, Corredor c2)
        {
            compet1 = c1;
            compet2 = c2;
            ganador = "";
        }

        public string Ganador{ get{ return ganador; } }

        public void Iniciar()
        {
            while(compet1.Pasos <= 80 && compet2.Pasos <= 80)
            {
                compet1.correr();
                compet2.correr();
                Console.WriteLine(compet1.ToString());
                Console.WriteLine(compet2.ToString());
            }
            if(compet1.Pasos > compet2.Pasos)
                ganador = "compet1";
            else if(compet1.Pasos < compet2.Pasos)
                ganador = "compet2";
            else
                ganador = "nadie";
        }

        public override string ToString()
        {
            string str = "El Ganador fue ";
            if(ganador == "compet1")
                return str += compet1.Nombre;
            if(ganador == "compet2")
                return str += compet2.Nombre;
            else
                return "Empate!!!";
        }
    }
}