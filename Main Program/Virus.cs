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
        }

        //Properties
        private int killcode;
        public string Naam { get; private set; }

        private int doomcountdown;

        public int DoomCountdown
        {
            get { return doomcountdown; }
            set
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
            int code = vaccin.TryKillCode();

            if (code == killcode)
            {
                code = vaccin.Oplossing;
                return true;
            }
            else
            {
                doomcountdown--;
                return false;
            }
        }

        










    }

}
