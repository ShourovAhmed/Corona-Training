using System;
using System.Collections.Generic;

namespace Main_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Virus corona = new Virus();

            var vaccins = new List<Vaccin>();
            for (int i = 0; i < 101; i++)
            {
                vaccins.Add(new Vaccin($"{i}"));
            }

            /*for (int i = 0; i < vaccins.Count; i++)
            {
                vaccins[i].ToonInfo();
            }*/

            for (int i = 0; i < vaccins.Count; i++)
            {
                corona.TryVaccin(vaccins[i]);
                vaccins[i].ToonInfo();
                Console.WriteLine("\n");
            }
            ;

        }
    }
}
