using System;

namespace TableauxListEnumerations1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] jours = new string[] { "Vendredi", "Mardi", "Samedi", "Mercredi", "Jeudi", "Lundi", "Dimanche" };

            //Mettre par ordre alphabétique
            string[] joursAlph = jours;
            Array.Sort(joursAlph);

            //Afficher chaque élément du tableau dans la console avec foreach
            Console.WriteLine("Tableau classé alphabétiquement:");
            foreach (string jour in joursAlph)
            {
                Console.WriteLine(jour);
            }
            Console.WriteLine();
            //Trier dans l'ordre inverse les éléments du tableau
            string[] joursInverse = joursAlph;
            Array.Reverse(joursInverse);

            //Afficher dans la console les éléments du tableau inversé
            Console.WriteLine("Tableau inversé:");
            foreach (string jour in joursInverse)
            {
                Console.WriteLine(jour);
            }
            Console.ReadKey();
        }
    }
}
