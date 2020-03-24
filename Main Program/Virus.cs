using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Program
{
    class Virus
    {
        Random r = new Random();

        //Default constructor
        public Virus()
        {
            DoomCountdown = r.Next(10, 21);
            killcode = r.Next(0, 100);
            char letter1 = Convert.ToChar(r.Next(65, 91));
            char letter2 = Convert.ToChar(r.Next(65, 91));
            char letter3 = Convert.ToChar(r.Next(65, 91));

            Naam = $"{letter1}{letter2}{letter3}{r.Next(1,100)}";
        }

        //Properties
        private int killcode;
        public string Naam { get; private set; }

        private int doomcountdown;

        public int DoomCountdown
        {
            get { return doomcountdown; }
            private set
            {
                if (doomcountdown <= 0)
                {
                    Console.WriteLine($"Game Over {Naam}");
                }
            }
        }


        //Methoden
        public bool TryVaccin(Vaccin vaccin)
        {
            int testcode = vaccin.TryKillCode();

            if (testcode == killcode)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Worked");
                Console.ResetColor();
                vaccin.Oplossing = testcode;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed");
                Console.ResetColor();
                DoomCountdown--;
                return false;
            }
        }

        










    }

}
