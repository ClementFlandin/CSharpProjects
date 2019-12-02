using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_OC
{
    public static class De
    {
        private static Random random = new Random();

        public static int LanceLeDe()
        {
            return random.Next(1, 7);
        }
        public static int LanceLeDe(int borneSup)
        {
            return random.Next(1, borneSup);
        }
    }
}
