using System;

namespace Test_Runs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            char letter1 = Convert.ToChar(r.Next(65, 91));
            char letter2 = Convert.ToChar(r.Next(65, 91));
            char letter3 = Convert.ToChar(r.Next(65, 91));

            string naam;

            Console.WriteLine($"{letter1}{letter2}{letter3}{r.Next(1,100)}");
            naam = $"{letter1}{letter2}{letter3}{r.Next(1, 100)}";
            Console.WriteLine(naam);
        }
    }
}
