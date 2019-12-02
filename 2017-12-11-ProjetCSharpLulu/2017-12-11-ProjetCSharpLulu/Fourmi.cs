using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_11_ProjetCSharpLulu
{
    abstract class Fourmi
    {
        public int[] Position { get; set; }
        public int[] Direction { get; set; }
        public ConsoleColor CouleurFourmi { get; set; }

        public virtual bool chgtDirection()
        {

            if (Console.BackgroundColor==ConsoleColor.Black)
                return true;
            else
                return false;
        }

        public virtual void chgtCouleurCase(ConsoleColor couleurFourmi)
        {
            if (Console.BackgroundColor == couleurFourmi)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if(Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = couleurFourmi;
            }
        }

        public virtual void deplacement(int[] position, int[] direction, ConsoleColor couleurFourmi)
        {
            position[0] += direction[0];
            position[1] += direction[1];
        }

        public virtual void arriveeBord(int[] position, int[]direction)
        {
            if (position[0]==0 || position[1]==49 || position[1] == 0 || position[0] == 49)
            {
                direction[0] = -direction[0];
                direction[1] = -direction[1];
            }
        }
    }
}
