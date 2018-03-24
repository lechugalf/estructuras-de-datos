using System;

namespace LiebreTortuga
{
    class Program
    {
        static void Main(string[] args)
        {
            Liebre liebre = new Liebre("Liebre Luke");
            Tortuga tortuga = new Tortuga("Tortuga John");
            
            Carrera carrera = new Carrera(liebre, tortuga);
            carrera.Iniciar();

            Console.WriteLine(carrera.ToString());
        }
    }
}
