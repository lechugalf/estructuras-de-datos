using System;

namespace GraficosPorTortuga
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafico grafico = new Grafico(10, 10);
            string salida = "";
            string comando = "";

            Console.WriteLine(grafico.EjecutarInstrucción("a"));

            do
            {
                comando = Console.ReadLine();
                salida = grafico.EjecutarInstrucción(comando);
                Console.WriteLine(salida);
            }
            while(comando != "x");
        }
    }
}
