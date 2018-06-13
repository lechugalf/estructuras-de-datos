using System;

namespace Practica12
{
    class CLI
    {
        ExpresionesAritmeticas analizador;

        public CLI(ExpresionesAritmeticas analizador)
        {
            this.analizador = analizador;
        }

        public void iniciar()
        {
            string cmd, salida;

            Console.WriteLine("::::::::::: ANALIZADOR DE EXPRESIONES ARITMETICAS :::::::::::");
            Console.WriteLine(EjecutarComando("h"));

            do
            {
                Console.WriteLine(">>>");
                cmd = Console.ReadLine();
                salida = EjecutarComando(cmd);
                Console.WriteLine(salida);
            }
            while(salida != "bye");
        }

        private string EjecutarComando(string cmd)
        {
            string salida = "";
            string args = "";

            switch (cmd)
            {
                case "new":
                    Console.WriteLine("expression: ");
                    args = Console.ReadLine();
                    args.Trim();
                    analizador.Expresion = args;
                    analizador.generarArbolBinario();
                    break;

                case "ex":
                    Console.WriteLine(analizador.Expresion);
                    break;

                case "tree":
                    break;

                case "inorder":
                    break;

                case "preorder":
                    break;

                case "h" : 
                    salida = "help";
                    break;

                case "q" :
                    salida = "bye";
                    break;

                default: salida = "comando desconocido! use 'h' para mostrar la lista comandos"; break;
            }
            return salida;
        }
    }
}
