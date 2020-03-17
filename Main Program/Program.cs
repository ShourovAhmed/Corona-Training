using System;
using System.Collections.Generic;

namespace Main_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Virus corona = new Virus();

            var vaccins = new List<Vaccin>(5);
            for (int i = 0; i < vaccins.Count; i++)
            {
                vaccins.Add(new Vaccin($"{i}"));
            }

            //vaccins.Add(new Vaccin("1"));
            //vaccins.Add(new Vaccin("2"));
            //vaccins.Add(new Vaccin("3"));
            //vaccins.Add(new Vaccin("4"));
            //vaccins.Add(new Vaccin("5"));


            for (int i = 0; i < vaccins.Count; i++)
            {
                corona.TryVaccin(vaccins[i]);
            }
            ;

        }
    }
}
