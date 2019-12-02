using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_POO_OC
{
    public class BossDeFin : PersonnageAPointsDeVie
    {
        public BossDeFin(int points)
        {
            PointsDeVie = points;
        }

        public void Attaque(Joueur joueur)
        {
            int nbPoints = LanceLeDe(26);
            joueur.SubitDegats(nbPoints);
        }
        
    }
}
