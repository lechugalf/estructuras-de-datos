using System;

namespace Practica12
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpresionesAritmeticas analizador = new ExpresionesAritmeticas();
            CLI cli = new CLI(analizador);
            cli.iniciar();
        }
    }
}
