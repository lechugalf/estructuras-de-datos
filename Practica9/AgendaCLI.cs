using System;

namespace Practica9
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
            Console.WriteLine("\nAgenda Linea de Comandos");
            Console.WriteLine("comandos: 'agregar','buscar','eliminar','listar', 'listar inv', 'eliminar ult', 'eliminar ini', 'salir', 'ayuda'");

            do
            {
                Console.WriteLine("--->");
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

                case "listar inv":
                    salida = agenda.ListarInverso();
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

                case "eliminar":
                    Console.WriteLine("Nombre a eliminar: ");
                    catcher = agenda.Eliminar(Console.ReadLine());
                    salida = (catcher == 0 ? "Contacto eliminado":"Contacto no encontrado");
                    break;

                case "eliminar ini":
                    agenda.EliminarInicio();
                    break;

                case "eliminar ult":
                    agenda.EliminarUltimo();
                    break;

                case "buscar":
                    Console.WriteLine("Nombre a buscar: ");
                    contacto = agenda.Buscar(Console.ReadLine());
                    if(contacto != null)
                        MostrarContacto(contacto);
                    else
                        salida = "Ningun contacto encontrado!";
                    break;

                case "ayuda":
                    salida = "comandos: 'agregar','buscar','eliminar','listar', 'listar inv', 'eliminar ult', 'eliminar ini', 'salir', 'ayuda'";
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

        private void MostrarContacto(Contacto contacto)
        {
            Console.WriteLine("Nombre:\t" + contacto.Nombre);
            Console.WriteLine("Apellido Pat:\t" + contacto.Apellido_p);
            Console.WriteLine("Apellido Mat:\t" + contacto.Apellido_m);
            Console.WriteLine("Edad:\t" + contacto.Edad);
            Console.WriteLine("Email:\t" + contacto.Email);
            Console.WriteLine("Telefono:\t" + contacto.Telefono);
        }
    }
}