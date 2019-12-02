using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_04_TP_Csharp_POOMeteo_OC
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulateurMeteo simulateurMeteo = new SimulateurMeteo(1000);
            Statisticien statisticien = new Statisticien(simulateurMeteo);
            statisticien.DemarrerAnalyse();
            statisticien.AfficherRapport();
        }
    }
}
