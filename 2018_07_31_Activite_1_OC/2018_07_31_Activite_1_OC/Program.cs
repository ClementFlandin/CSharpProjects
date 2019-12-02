using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_07_31_Activite_1_OC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue!");
            int[] tableau = new int[] { 0, 0, 0, 0, 0, 0, 0};

            int tour = 0;
            int tirage;
            Random random = new Random();

            while (tour < 7)
            {
                do
                {
                    tirage = random.Next(1, 50);
                } while (tableau.Contains(tirage) == true);
                tableau[tour] = tirage;
                tour++;
                
            }
            afficherTableau(tableau);
        }

        static void afficherTableau(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
