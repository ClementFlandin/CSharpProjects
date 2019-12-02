using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_POO_OC
{
    public abstract class Personnage
    {
        public abstract bool EstVivant { get; }

        public abstract void Attaque(Personnage perso);

        public abstract void SubitDegats(int degats);

        public int LanceLeDe()
        {
            return De.LanceLeDe();
        }
    }
}
