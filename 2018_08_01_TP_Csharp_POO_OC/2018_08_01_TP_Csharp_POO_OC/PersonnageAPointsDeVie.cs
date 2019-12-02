using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_POO_OC
{
    public abstract class PersonnageAPointsDeVie : Personnage
    {
        public int PointsDeVie { get; set; }

        public override bool EstVivant
        {
            get
            {
                return PointsDeVie > 0;
            }
        }

        public override void SubitDegats(int degats)
        {
            PointsDeVie -= degats;
        }
        public override void Attaque(Personnage perso)
        {
            if(perso is Joueur || perso is BossDeFin)
            {
                int lance = LanceLeDe(26);
                perso.SubitDegats(lance);
            }
        }

        public int LanceLeDe(int maxDegats)
        {
            return De.LanceLeDe(maxDegats);
        }
    }
}
