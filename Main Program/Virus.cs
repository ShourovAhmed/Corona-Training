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
                doomcountdown = value;
                if (doomcountdown <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Game Over, yours sincerely {Naam}!");
                    Console.ResetColor();
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
                Console.WriteLine($"Succes, you have defeated {Naam}");
                Console.ResetColor();
                vaccin.Oplossing = testcode;
                return true;
            }
            else
            {
                DoomCountdown--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed");
                Console.ResetColor();
                return false;
            }
        }

        










    }

}
