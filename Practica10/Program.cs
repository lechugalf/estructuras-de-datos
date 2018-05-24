using System;

namespace ListaCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            Controlador controlador = new Controlador();
            CLI cli = new CLI(controlador);
            cli.iniciar();
        }
    }
}
