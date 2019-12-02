using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_POO_OC
{
    public class Joueur : PersonnageAPointsDeVie
    {
        public Joueur(int pdv)
        {
            PointsDeVie = pdv;
        }

        public override void Attaque(Personnage perso)
        {
            if(perso is BossDeFin)
            {
                base.Attaque(perso);
            }
            else
            {
                int lanceJoueur = LanceLeDe();
                int lanceMonstre = LanceLeDe();
                if (lanceJoueur >= lanceMonstre)
                    perso.SubitDegats(lanceJoueur);
            }
        }
    
        public override void SubitDegats(int degats)
        {
            if (!BouclierFonctionne())
                base.SubitDegats(degats);
        }

        private bool BouclierFonctionne()
        {
            return De.LanceLeDe() <= 2;
        }
    }
}
