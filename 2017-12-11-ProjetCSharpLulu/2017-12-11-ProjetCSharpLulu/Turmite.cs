using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_11_ProjetCSharpLulu
{
    class Turmite : Fourmi
    {
        public Turmite(int[] position, int[] direction, ConsoleColor couleurFourmi)
        {
            
        }

        public override bool chgtDirection()
        {
            return base.chgtDirection();
        }

        public override void chgtCouleurCase(ConsoleColor couleurFourmi)
        {
            base.chgtCouleurCase(couleurFourmi);
        }

        public override void deplacement(int[] position, int[] direction, ConsoleColor couleurFourmi)
        {
            base.deplacement(position, direction, couleurFourmi);
        }

        public override void arriveeBord(int[] position, int[] direction)
        {
            base.arriveeBord(position, direction);
        }
    }
}
