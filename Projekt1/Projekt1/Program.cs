using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Say();

            Bravo();
        }

        private static void Bravo()
        {
            Console.WriteLine();
            Console.WriteLine("Brawo! Pierwsze zadanie zrobione :)");
            Console.WriteLine("Naciśnij jakikolwiek klawisz aby zakończyć...");
            Console.ReadKey();
        }



        private static void Say()
        {
            Console.WriteLine("Hello world");
        }
    }
}