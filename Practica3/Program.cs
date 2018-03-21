using System;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Primos primos = new Primos(1000);
            Console.WriteLine(primos.fprimos());
        }
    }
}
