using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_OC
{
    public class MonstreFacile
    {
        private const int degats = 10;
        public bool EstVivant { get; private set; }

        public MonstreFacile()
        {
            EstVivant = true;
        }

        public virtual void Attaquer(Joueur joueur)
        {
            int lanceMonstre = LanceLeDe();
            int lanceJoueur = joueur.LanceLeDe();
            if (lanceMonstre > lanceJoueur)
            {
                joueur.SubitDegats(degats);
            }
        }

        public void SubitDegats()
        {
            EstVivant = false;
        }
        public int LanceLeDe()
        {
            return De.LanceLeDe();
        }
    }
}
