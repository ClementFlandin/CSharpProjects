using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_11_ProjetCSharpLulu
{
    class FourmiDeLangton : Fourmi
    {
        public FourmiDeLangton(int[] position, int[] direction, ConsoleColor couleurFourmi)
        {
            Position = position;
            Direction = direction;
            CouleurFourmi = couleurFourmi;
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
            
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                direction[1] = direction[0];
                direction[0] = 0;
                //Console.BackgroundColor = couleurFourmi;
                //chgtCouleurCase(couleurFourmi);

            }
            else if(Console.BackgroundColor == couleurFourmi)
            {
                direction[1] = -direction[0];
                direction[0] = 0;
                //Console.BackgroundColor = ConsoleColor.Black;
                //chgtCouleurCase(couleurFourmi);
            }
            base.deplacement(position, direction, couleurFourmi);
        }

        public override void arriveeBord(int[] position, int[] direction)
        {
            base.arriveeBord(position, direction);
        }
    }
}
