using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string maChaineAConvertir = Console.ReadLine();
            double resultat;
            if (!Double.TryParse(maChaineAConvertir, out resultat))
            {
                Console.WriteLine("Tu n'as pas rentré un nombre");
            }
            else if (resultat >= 0)
            {
                Console.WriteLine("Tu as rentré un nombre positif");
            }
            else
            {
                Console.WriteLine("Tu as rentré un nombre négatif");
            }
            Console.ReadKey();
        }
    }
}
