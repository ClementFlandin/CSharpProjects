using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_04_TP_Csharp_POOLists_OC
{
    public class Chainage<T>
    {
        public Chainage<T> Precedent { get; set; }
        public Chainage<T> Suivant { get; set; }
        public T Valeur { get; set; }
    }
}
