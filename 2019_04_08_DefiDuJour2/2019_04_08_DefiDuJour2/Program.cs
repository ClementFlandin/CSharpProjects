using System;
using System.Collections.Generic;

namespace ListeDeCourses
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> articles = new List<string> ();

            //Demande à l'utilisateur de rentrer le nom d'un article, différent de la chaîne vide
            bool listeFinie = false;

            do
            {
                Console.WriteLine("Veuillez rentrer le nom d'un article :");
                string article = Console.ReadLine();
                if (article == "")
                    listeFinie = true;
                else
                    articles.Add(article);
            } while (!listeFinie);

            //Trie les articles par ordre alphabétique
            articles.Sort();

            //Affiche la liste des articles sur la même ligne, séparés par une virgule
            Console.WriteLine(string.Join(",", articles));

            //Affiche le nombre d'articles dans la liste
            Console.WriteLine(String.Format("Vous avez {0} articles dans votre liste!", articles.Count));

        }
    }
}