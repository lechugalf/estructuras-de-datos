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

            Console.WriteLine("::::::::::: ANALIZADOR DE EXPRESIONES ARITMETICAS :::::::::::\n");
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

                case "exp":
                    Console.WriteLine(analizador.Expresion);
                    break;

                case "post":
                Console.WriteLine(analizador.Postorden);
                    break;

                case "pre":
                    Console.WriteLine(analizador.Preorden);
                    break;

                case "h" : 
                    salida = "Comando  Acción\n" +
                             "new  ->  Ingresar nueva expresion\n" +
                             "exp  ->  Mostrar expresión actual\n" +
                             "post ->  Mostrar recorrido postorden\n" +
                             "pre  ->  Mostrar recorrido preorden\n" + 
                             "quit ->  Salir\n";
                    break;

                case "quit" :
                    salida = "bye";
                    break;

                default: salida = "comando desconocido! use 'h' para mostrar la lista comandos"; break;
            }
            return salida;
        }
    }
}
