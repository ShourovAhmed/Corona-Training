using System;
using System.Collections.Generic;

namespace Main_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Fase1_2();
        }

        //Methoden
        static void Fase1_2()
        {
            //Fase 1
            Virus corona = new Virus();

            var vaccins = new List<Vaccin>();
            for (int i = 0; i < 51; i++)
            {
                vaccins.Add(new Vaccin($"{i}"));
            }

            bool cureGevonden = false;
            Vaccin theCure = null;
            for (int i = 0; i < vaccins.Count; i++)
            {
                cureGevonden = corona.TryVaccin(vaccins[i]);
                vaccins[i].ToonInfo();
                Console.WriteLine("\n");

                //GAME OVER
                if (corona.DoomCountdown <= 0)
                {
                    break;
                }

                //Game Continues...
                if (cureGevonden == true)
                {
                    theCure = vaccins[i];
                    break;
                }
            }


            //Fase 2
            if (cureGevonden == true)
            {

                theCure.ToonInfo();
                VaccinatieCentrum.BewaarVaccin(theCure.Oplossing);

                List<VaccinatieCentrum> centra = new List<VaccinatieCentrum>();
                for (int j = 0; j < 5; j++)//nieuwe vaccinatiecentra aanmaken
                {
                    centra.Add(new VaccinatieCentrum());
                }

                List<Vaccin> containerVaccins = new List<Vaccin>();
                foreach (var centrum in centra)//aan elk centrum in de lijst 'centra' 7x vaccin geven
                {
                    for (int k = 0; k < 7; k++)
                    {
                        containerVaccins.Add(centrum.GeefVaccin());
                    }
                }

                for (int l = 0; l < containerVaccins.Count; l++)
                {
                    Console.Write(l+1 + " ");
                    containerVaccins[l].ToonInfo();
                }

            }
        }




    }
}
