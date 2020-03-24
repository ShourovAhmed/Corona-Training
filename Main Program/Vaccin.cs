using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Program
{
    class Vaccin
    {
        Random r = new Random();

        //Constructors
        //Overloaded (default) constructor
        public Vaccin(string naam)
        {
            Naam = naam;
        }

        //Constructor voor Vaccinatiecentrum klasse
        public Vaccin (string naam, int solution)
        {
            Naam = naam;
            Oplossing = solution;
            TryKillCode();
        }


        //Properties
        public string Naam { get; private set; }
        public int Oplossing { get; set; } = -1;

        //Methoden
        public int TryKillCode()
        {
            int code = r.Next(1, 101);
            if (Oplossing != -1)
            {
                return Oplossing;
            }
            else
            {
                return code;
            }
        }

        public void ToonInfo()
        {

            Console.WriteLine($"Vaccin: {Naam}");
            Console.WriteLine($"Oplossing: {Oplossing}");

        }


    }
}
