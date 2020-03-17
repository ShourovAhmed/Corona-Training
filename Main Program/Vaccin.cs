using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Program
{
    class Vaccin
    {
        Random r = new Random();

        //Overloaded constructor
        public Vaccin(string naam)
        {
            Naam = naam;
        }

        //Properties
        public string Naam { get; private set; }
        public int Oplossing { get; set; } = -1;

        //Methoden
        public int TryKillCode()
        {
            if (Oplossing != -1)
            {
                return Oplossing;
            }
            else
            {
              return r.Next(1, 101);
            }
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Vaccin: {Naam}");
            Console.WriteLine(Oplossing);

        }


    }
}
