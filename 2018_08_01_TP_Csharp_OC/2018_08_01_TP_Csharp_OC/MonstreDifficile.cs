using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_OC
{
    public class MonstreDifficile : MonstreFacile
    {
        private const int degatsSort = 5;

        public override void Attaquer(Joueur joueur)
        {
            base.Attaquer(joueur);
            joueur.SubitDegats(sortMagique());
        }
        private int sortMagique()
        {
            int lance = LanceLeDe();
            if (lance == 6)
                return 0;
            else
                return degatsSort * lance;
        }
    }
}
