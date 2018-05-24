using System;

namespace ListaCircular
{
    class CLI
    {
        Controlador controlador;

        public CLI(Controlador controlador)
        {
            this.controlador = controlador;
        }

        public void iniciar()
        {
            string cmd, salida;

            Console.WriteLine(":::::::: CONTROL DEL SISTEMA DE AUTOBUSES ::::::::");
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
            Estacion estacion;

            switch (cmd)
            {
                case "a" : 
                    estacion = FormularioEstacion();
                    if(estacion != null){
                        controlador.AgregarFinal(estacion);
                        salida = "Hecho..";
                    }
                    break;

                case "ls": 
                    salida = controlador.ListarEstaciones();
                    break;

                case "bu":
                    estacion = controlador.Buscar(Console.ReadLine());
                    salida = (estacion!=null) ? estacion.ToString() : "no encontrado..";
                    break;

                case "re":
                    salida = controlador.Ruta(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                    
                case "h" : 
                    salida = "##################################################\n"+
                    "# Comandos:                                      #\n" +
                    "# Agregar Estación  : 'a'   Quitar Estación   : 'rm'    #\n" +
                    "# Listar Estaciones : 'r'   Listar Estaciones : 'ls'    #\n" +
                    "##################################################\n";
                    break;

                case "q" :
                    salida = "bye";
                    break;

                default: salida = "comando desconocido! use 'h' para mostrar la lista comandos"; break;
            }
            return salida;
        }

        private Estacion FormularioEstacion()
        {
            string confirmar = "";
            Console.WriteLine("Agregar Estación");
            Estacion nuevaEstacion = new Estacion();

            Console.WriteLine("Nombre de la Estacion: ");
            nuevaEstacion.Nombre = Console.ReadLine();
            Console.WriteLine("Tiempo(minutos) en llegar desde la ultima estacion: ");
            nuevaEstacion.Tiempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Seguro en esta agregar esta estación? S/N");
            confirmar = Console.ReadLine();
            
            if(confirmar.ToUpper() == "S")
                return nuevaEstacion;
            return null;
        }
    }
}
