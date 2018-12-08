using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y = a * (x * x) + b  * y + c");
            Console.Write("podaj wartośc a = ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj wartośc b = ");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj wartośc c = ");
            var c = Convert.ToDouble(Console.ReadLine());

            Calculate(a, b, c);

            Console.WriteLine("Brawo! Czwarte zadanie zrobione :)");
            Console.WriteLine("Naciśnij jakikolwiek klawisz aby zakończyć...");
            Console.ReadKey();
        }

        private static void Calculate(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            Console.WriteLine("delta = " + delta);

            if (delta>0)
            {
                Console.WriteLine("Funkcja ma dwa miejsca zerowe");
                double square = Math.Sqrt(delta);
                Console.WriteLine("pierwiastek z delty = " + square);
                double x1 = (-b + square) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                double x2 = (-b - square) / (2 * a);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                if (delta <0)
                {
                    Console.WriteLine("Funkcja nie ma miejsc zerowych");
                }
                else
                {
                    delta = 0;
                    Console.WriteLine("Funkcja ma jedno miejsce zerowe");
                    double x0 = (-b) / (2 * a);
                    Console.WriteLine("x0 = " + x0);
                }
            }
        }
    }
}