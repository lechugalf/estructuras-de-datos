using System;

namespace Practica11
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor myProcessor = new Processor();
            myProcessor.ProcessTaskThread(300, 0.35);
            Console.WriteLine(myProcessor.Log);
        }
    }
}
