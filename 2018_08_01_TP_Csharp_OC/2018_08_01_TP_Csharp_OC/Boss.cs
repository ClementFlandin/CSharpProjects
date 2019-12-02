using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_OC
{
    public class Boss
    {
        public int PointsDeVie { get; private set; }
        public bool EstVivant
        {
            get { return PointsDeVie > 0; }
        }

        public Boss(int pointsDeVie)
        {
            PointsDeVie = pointsDeVie;
        }

        public void Attaquer(Joueur joueur)
        {
            int pointsDegats = LanceLeDe(26);
            joueur.SubitDegats(pointsDegats);
        }
        public void SubitDegats(int degats)
        {
            PointsDeVie -= degats;
        }
        private int LanceLeDe(int valeur)
        {
            return De.LanceLeDe(valeur);
        }
    }
}
