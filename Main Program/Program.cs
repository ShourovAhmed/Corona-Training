using System;
using System.Collections.Generic;

namespace Main_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Fase1();
        }

        //Methoden
        static void Fase1()
        {
            Virus corona = new Virus();

            var vaccins = new List<Vaccin>();
            for (int i = 0; i < 51; i++)
            {
                vaccins.Add(new Vaccin($"{i}"));
            }


            for (int i = 0; i < vaccins.Count; i++)
            {
                bool Werkt = corona.TryVaccin(vaccins[i]);
                vaccins[i].ToonInfo();
                Console.WriteLine("\n");

                if (Werkt == true)
                {
                    break;
                }

                if (corona.DoomCountdown <= 0)
                {
                    break;
                }
            }
        }




    }
}
