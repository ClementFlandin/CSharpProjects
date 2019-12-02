using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_04_05_DefiFruits
{
    public class Fruit : Aliment
    {
        public Fruit(string n, string c, string f) : base(n,c,f)
        {

        }

        public override string Decrire()
        {
            return base.Decrire().Replace("'aliment","e fruit");
        }
    }
}
