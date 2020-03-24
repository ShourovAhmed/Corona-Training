using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Program
{
    class VaccinatieCentrum
    {

        //Propertys
        static public int Oplossing { get  ; set; } = -1;

        //Methoden
        public static void BewaarVaccin(int killcodein)
        {
            Oplossing = killcodein;
        }

        public Vaccin GeefVaccin()
        {
            if (Oplossing == -1) return null;

            //else
            return new Vaccin("The Cure", Oplossing);
        }
    }
}
