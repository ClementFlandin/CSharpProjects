using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_04_TP_Csharp_POOLists_OC
{
    public class ListeChaineeEnumerator<T> : IEnumerator<T>
    {
        private Chainage<T> courant;
        private ListeChainee<T> listeChainee;

        public ListeChaineeEnumerator(ListeChainee<T> liste)
        {
            courant = null;
            listeChainee = liste;
        }
        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (courant == null)
                courant = listeChainee.Premier;
            else
                courant = courant.Suivant;
            return courant != null;
        }

        public T Current
        {
            get
            {
                if (courant == null)
                    return default(T);
                return courant.Valeur;
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
        

        public void Reset()
        {
            courant = null;
        }
    }
}
