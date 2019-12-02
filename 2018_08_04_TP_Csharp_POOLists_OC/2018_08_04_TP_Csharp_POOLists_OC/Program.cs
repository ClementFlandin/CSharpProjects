using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_04_TP_Csharp_POOLists_OC
{
    class Program
    {
        static void Main(string[] args)
        {
            ListeChainee<int> listeChainee = new ListeChainee<int>();
            listeChainee.Ajouter(5);
            listeChainee.Ajouter(10);
            listeChainee.Ajouter(4);
            Console.WriteLine(listeChainee.Premier.Valeur);
            Console.WriteLine(listeChainee.Premier.Suivant.Valeur);
            Console.WriteLine(listeChainee.Premier.Suivant.Suivant.Valeur);
            Console.WriteLine("*************");
            Console.WriteLine(listeChainee.ObtenirElement(0).Valeur);
            Console.WriteLine(listeChainee.ObtenirElement(1).Valeur);
            Console.WriteLine(listeChainee.ObtenirElement(2).Valeur);
            Console.WriteLine("*************");
            listeChainee.Inserer(99, 0);
            listeChainee.Inserer(33, 2);
            listeChainee.Inserer(30, 2);
            Console.WriteLine(listeChainee.ObtenirElement(0).Valeur);
            Console.WriteLine(listeChainee.ObtenirElement(1).Valeur);
            Console.WriteLine(listeChainee.ObtenirElement(2).Valeur);
            Console.WriteLine(listeChainee.ObtenirElement(3).Valeur);
            Console.WriteLine(listeChainee.ObtenirElement(4).Valeur);
            Console.WriteLine(listeChainee.ObtenirElement(5).Valeur);
        }
    }
}
