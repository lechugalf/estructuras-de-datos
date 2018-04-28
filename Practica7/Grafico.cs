using System;
using System.Drawing;

namespace GraficosPorTortuga
{
    class Grafico
    {
        private bool[,] matriz;
        private Tortuga tortuga;

        public Grafico(int alto, int ancho)
        {
            matriz = new bool[alto, ancho];
            tortuga = new Tortuga(0, alto-1, 2);
        }

        private string Mostrar()
        {
            string grafico = "";

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if(matriz[j, i] == false) 
                        grafico += "0" + " "; //▒ 
                    else
                        grafico += "1" + " "; //█

                grafico += '\n';
            }

            return grafico;
        }

        private bool PintarMovimiento(int pasos)
        {
            Tortuga mideLimite;
            int contador = 0;
            if(tortuga.EstadoPluma)
                        matriz[tortuga.Posicion.X, tortuga.Posicion.Y] = true;

            while(contador < pasos)
            {
                mideLimite = new Tortuga(tortuga.Posicion.X, tortuga.Posicion.Y, tortuga.Direccion);
                mideLimite.Avanzar();

                if(mideLimite.Posicion.X >= matriz.GetLength(0) || mideLimite.Posicion.X < 0 || mideLimite.Posicion.Y >= matriz.GetLength(1) || mideLimite.Posicion.Y < 0)
                    return false;
                else
                {
                    tortuga.Avanzar();
                    if(tortuga.EstadoPluma)
                        matriz[tortuga.Posicion.X, tortuga.Posicion.Y] = true;
                }

                contador++;
            }
            return true;
        }

        public string EjecutarInstrucción(string cmd)
        {
            if(cmd.IndexOf("m") == 0 && cmd.Length > 0)
            {
                int pasos = int.Parse(cmd.Substring(1));

                if(!PintarMovimiento(pasos))
                    return "tortuga fuera de los limites"; 
            }

            else
            {
                switch(cmd)
                {
                    case "d":
                        tortuga.GirarDerecha();
                        break;

                    case "i":
                        tortuga.GirarIzquierda();
                        break;

                    case "s":
                        tortuga.SubirPluma();
                        break;

                    case "b":
                        tortuga.BajarPluma();
                        break;

                    case "v":
                        return Mostrar();

                    case "x":
                        return Mostrar();

                    case "a":
                        return "Grafico generado por una tortuga la cual se encuentra en la esquina inferior izquierda mirando hacia el Este. Puedes mover la tortuga y ordenarle que pinte bajando y subiendo su pluma. Usa los siguientes comandos para decirle que hacer\nComandos\nPara mover 'm' seguido del numero de pasos\nPara cambiar de direccion: girar derecha='d', girar izquierda='i'\nPara bajar y subir la pluma: bajar='b', subir='s'\nPara mostrar el grafico 'v'\nPara terminar'x' y para mostrar ayuda 'a'";

                    case "estado":
                        return tortuga.ToString();

                    default:
                        return "Comando desconocido!";
                }
            }
            return null;
        }
    }
}