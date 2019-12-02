using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_OC
{
    public class Joueur
    {
        public int PointsDeVie { get; private set; }

        public bool EstVivant
        {
            get
            {
                return PointsDeVie > 0;
            }
        }

        public Joueur(int pdv)
        {
            PointsDeVie = pdv;
        }

        public void Attaquer(MonstreFacile mf)
        {
            int lanceJoueur = LanceLeDe();
            int lanceMonstre = mf.LanceLeDe();
            if(lanceJoueur >= lanceMonstre)
            {
                mf.SubitDegats();
            }
        }
        public void AttaquerBoss(Boss boss)
        {
            int lanceJoueur = LanceLeDe(26);
            boss.SubitDegats(lanceJoueur);
        }

        public int LanceLeDe(int valeur)
        {
            return De.LanceLeDe(valeur);
        }
        public int LanceLeDe()
        {
            return De.LanceLeDe();
        }

        public void SubitDegats(int degatsInfliges)
        {
            if (!BouclierFonctionne())
            {
                PointsDeVie -= degatsInfliges;
            }
        }

        public bool BouclierFonctionne()
        {
            return De.LanceLeDe() <= 2;
        }
    }
}
