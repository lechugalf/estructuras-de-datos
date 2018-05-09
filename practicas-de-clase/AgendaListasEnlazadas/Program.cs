using System;

namespace AgendaListasEnlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            AgendaCLI cli = new AgendaCLI(agenda);
            cli.Iniciar();
        }
    }
}
