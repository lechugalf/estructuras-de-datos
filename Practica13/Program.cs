using System;

namespace Practica13
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor myProcessor = new Processor();
            myProcessor.ProcessTaskThread(50, 0.20);
            Console.WriteLine(myProcessor.Log);
        }
    }
}
