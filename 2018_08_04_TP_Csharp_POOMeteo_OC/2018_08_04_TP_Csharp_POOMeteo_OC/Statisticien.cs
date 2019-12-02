using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_04_TP_Csharp_POOMeteo_OC
{
    class Statisticien
    {
        private SimulateurMeteo simulateurMeteo;
        private int nombreDeFoisOuLeTempsAChange;
        private int nombreDeFoisOuIlAFaitSoleil;

        public Statisticien(SimulateurMeteo simulateur)
        {
            simulateurMeteo = simulateur;
            nombreDeFoisOuLeTempsAChange = 0;
            nombreDeFoisOuIlAFaitSoleil = 0;
        }

        public void DemarrerAnalyse()
        {
            nombreDeFoisOuLeTempsAChange = 0;
            nombreDeFoisOuIlAFaitSoleil = 0;
            simulateurMeteo.QuandLeTempsChange += simulateurMeteo_QuandLeTempsChange;
            simulateurMeteo.Demarrer();
            simulateurMeteo.QuandLeTempsChange -= simulateurMeteo_QuandLeTempsChange;
        }
        public void AfficherRapport()
        {
            Console.WriteLine("Nombre de fois où le temps a changé : " + nombreDeFoisOuLeTempsAChange);
            Console.WriteLine("Nombre de fois où il a fait soleil : " + nombreDeFoisOuIlAFaitSoleil);
            Console.WriteLine("Pourcentage de beau temps : " + nombreDeFoisOuIlAFaitSoleil * 100 / nombreDeFoisOuLeTempsAChange + " %");
        }
        private void simulateurMeteo_QuandLeTempsChange(Temps temps)
        {
            if (temps == Temps.Soleil)
                nombreDeFoisOuIlAFaitSoleil++;
            nombreDeFoisOuLeTempsAChange++;
        }
    }
}
