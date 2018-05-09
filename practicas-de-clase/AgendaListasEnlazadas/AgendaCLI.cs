using System;

namespace AgendaListasEnlazadas
{
    class AgendaCLI
    {
        Agenda agenda;

        public AgendaCLI(Agenda agenda)
        {
            this.agenda = agenda;
        }

        public void Iniciar()
        {
            string cmd, salida;
            Console.WriteLine("Agenda Linea de Comandos");

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
            Contacto contacto;
            int catcher;

            string salida = "";
            switch (cmd)
            {
                case "listar":
                    salida = agenda.Listar();
                    break;

                case "salir":
                    salida = "bye";
                    break;

                case "agregar":
                    contacto = ContactoFormulario();
                    if(contacto != null)
                    {
                        agenda.Agregar(contacto);
                        salida = "hecho..";
                        break;
                    }
                    salida = "cancelado";
                    break;

                case "insertar":
                    contacto = ContactoFormulario();
                    if(contacto != null)
                    {
                        Console.WriteLine("insertar en posicion:");
                        catcher = Console.Read();
                        agenda.Insertar(catcher, contacto);
                        salida = "hecho..";
                        break;
                    }
                    salida = "cancelado";
                    break;

                case "eliminar":
                    catcher = agenda.Eliminar(Console.ReadLine());
                    salida = (catcher == 0 ? "Contacto eliminado":"Contacto no encontrado");
                    break;

                default:
                    salida = "Comando desconocido!";
                    break;
            }
            return salida;
        }

        private Contacto ContactoFormulario()
        {
            Contacto contacto = new Contacto();
            string confirm = "";

            Console.WriteLine("Nombre:");
            contacto.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno:");
            contacto.Apellido_p = Console.ReadLine();
            Console.WriteLine("Apellido Materno:");
            contacto.Apellido_m = Console.ReadLine();
            Console.WriteLine("Edad");
            contacto.Edad = Console.ReadLine();
            Console.WriteLine("Email:");
            contacto.Email = Console.ReadLine();
            Console.WriteLine("Telefono:");
            contacto.Telefono = Console.ReadLine();
            Console.WriteLine("Seguro que desea agregar s/n");
            confirm = Console.ReadLine();

            if(confirm.ToUpper() == "S")
                return contacto;

            return null;
        }
    }
}