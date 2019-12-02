using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_03_26_NbreMystere
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int nbreMystere = rand.Next(1, 10);
            int nbreRentre = 0;
            Console.WriteLine("Quel est le nombre mystère?");
            do
            {
                string saisie = Console.ReadLine();
                nbreRentre = Convert.ToInt32(saisie);
                if (nbreRentre < nbreMystere)
                {
                    Console.WriteLine("C'est plus!");
                }
                if (nbreRentre>nbreMystere)
                {
                    Console.WriteLine("C'est moins!");
                }
            } while (nbreRentre!=nbreMystere);
            Console.WriteLine("Féliciations vous avez trouvé le nombre mystère!");
            Console.ReadKey();
        }
    }
}
