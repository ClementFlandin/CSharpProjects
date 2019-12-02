using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_11_13_CollectionsExo
{
    public class Article : INotifyPropertyChanged
    {
        private int _referenceNum;
        public int ReferenceNum { get { return _referenceNum; } set { if (_referenceNum != value) { _referenceNum = value; NotifyPropertyChanged("ReferenceNum"); } } }

        private string _nom;
        public string Nom { get { return _nom; } set { if (_nom != value) { _nom = value; NotifyPropertyChanged("Nom"); } } }

        private int _prixVente;
        public int PrixVente { get { return _prixVente; } set { if (_prixVente != value) { _prixVente = value; NotifyPropertyChanged("PrixVente"); } } }

        private int _qteStock;
        public int QteStock { get { return _qteStock; } set { if (_qteStock != value) { _qteStock = value; NotifyPropertyChanged("QteStock"); } } }

        public Article(int referenceNum, string nom, int prixVente, int qteStock)
        {
            ReferenceNum = referenceNum;
            Nom = nom;
            PrixVente = prixVente;
            QteStock = qteStock;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        public override string ToString()
        {
            return Nom + " référence numéro : " + ReferenceNum + ", coutant : " + PrixVente + ", il reste " + QteStock + " articles en stock!";
        }

    }
}
