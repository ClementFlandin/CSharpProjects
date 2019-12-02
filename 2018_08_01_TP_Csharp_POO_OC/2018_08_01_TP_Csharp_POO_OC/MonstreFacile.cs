using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_POO_OC
{
    public class MonstreFacile : Personnage
    {
        private const int degats = 10;
        /* Explication de ce qui suit: initialisation de degats subits (infligés par le joueur), qui n'est plus nul dès qu'il reçoit un coup, et donc meurt...Couic!
        C'est la seule solution que j'aie trouvé pour indiquer la mort d'un monstre... 
        Pas sûr que ce soit la bonne solution?*/
        public int degatsSubits=0;
        public override bool EstVivant
        {
            get
            {
                return degatsSubits == 0;
            }
        }

        public MonstreFacile()
        {

        }
        
        public override void Attaque(Personnage joueur)
        {
            int lanceMonstre = LanceLeDe();
            int lanceJoueur = joueur.LanceLeDe();
            if (lanceMonstre > lanceJoueur)
                joueur.SubitDegats(degats);
        }

        public override void SubitDegats(int degats)
        {
            degatsSubits = degats;
        }
    }
}
