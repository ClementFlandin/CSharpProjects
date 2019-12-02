using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_04_05_DefiFruits
{
    public class Aliment
    {
        private string _nom = "";
        private string _couleur = "";
        private string _forme = "";

        public string Nom
        {
            get { return _nom; }
            set { }
        }

        /// <summary>
        /// Couleur est une propriété
        /// Elle permet d'accéder à la couleur du fruit sans faire appel à la variable _couleur
        /// L'accesseur get permet de retourner la valeur de _couleur
        /// L'accesseur set est vide et ne permet donc pas de définir une valeur pour _couleur
        /// </summary>
        public string Couleur
        {
            get { return _couleur; }
            set { }
        }

        public string Forme
        {
            get { return _forme; }
            set { }
        }

        /// <summary>
        /// La classe Fruit prend deux paramètres lors de l'instanciation
        /// </summary>
        /// <param name="n">Le nom du fruit</param>
        /// <param name="c">La couleur du fruit</param>
        /// <param name="f">La forme du fruit</param>
        public Aliment(string n, string c, string f)
        {
            this._nom = n;
            this._couleur = c;
            this._forme = f;
        }

        public virtual string Decrire()
        {
            return String.Format("L'aliment nommé {0} est de couleur {1} et de forme {2}.", _nom, _couleur, _forme);
        }
    }
}
