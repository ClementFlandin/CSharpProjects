using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_08_ProjetLogique
{
    public class Arbre
    {
        public void creationArbre(int nbNiveaux)
        {
            List<int> arbre = new List<int>();
            int noeud = 0;
            for (int i = 0; i < nbNiveaux; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    arbre.Add(noeud);
                    noeud++;
                }
            }
        }

        public void ajoutFils(int nbNiveaux, List<int> arbre)
        {
            int dernier = arbre.Last();
            for (int i = dernier+1; i < (int)Math.Pow(2,nbNiveaux-1); i++)
            {
                arbre.Add(i);
            }
        }

        public void afficherArbre(int nbNiveaux, List<int> arbre)
        {
            int noeud = 0;
            for (int i = 0; i < nbNiveaux; i++)
            {
                Console.Write(arbre[noeud]);
                noeud++;
                if ()
                {

                }
            }
        }
    }
}
