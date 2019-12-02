using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_04_TP_Csharp_POOMeteo_OC
{
    public class SimulateurMeteo
    {
        private Temps? ancienTemps;
        private int nombreDeRepetitions;
        private Random random;
        public delegate void IlFaitBeauDelegate(Temps temps);
        public event IlFaitBeauDelegate QuandLeTempsChange;

        public SimulateurMeteo(int nombre)
        {
            random = new Random();
            ancienTemps = null;
            nombreDeRepetitions = nombre;
        }

        public void Demarrer()
        {
            for (int i = 0; i < nombreDeRepetitions; i++)
            {
                int valeur = random.Next(0, 100);
                if (valeur < 5)
                {
                    GererTemps(Temps.Soleil);
                }
                else
                {
                    if (valeur < 50)
                    {
                        GererTemps(Temps.Nuage);
                    }
                    else
                    {
                        if (valeur < 90)
                            GererTemps(Temps.Pluie);
                        else
                            GererTemps(Temps.Orage);
                    }
                }
            }

            
        }

        private void GererTemps(Temps temps)
        {
            if (ancienTemps.HasValue && ancienTemps.Value != temps && QuandLeTempsChange != null)
                QuandLeTempsChange(temps);
            ancienTemps = temps;
        }
    }
}
