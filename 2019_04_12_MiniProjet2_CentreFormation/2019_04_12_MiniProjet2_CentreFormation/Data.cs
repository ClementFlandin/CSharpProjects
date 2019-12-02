using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace _2019_04_12_MiniProjet2_CentreFormation
{
    class Data
    {
        static public IEnumerable<Eleve> RecupererListeEleves()
        {
            using (LiteDatabase db = new LiteDatabase("base.db"))
            {
                
                return db.GetCollection<Eleve>().FindAll();
            }
        }
        static public void AjouterEleve(Eleve eleve)
        {
            using (LiteDatabase db = new LiteDatabase("base.db"))
            {
                LiteCollection<Eleve> listeEleves = db.GetCollection<Eleve>();

                listeEleves.Insert(eleve);
            }
        }


    }

    class Eleve : IComparable
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public string TelFixe { get; set; }
        public string TelMobile { get; set; }

        public int CompareTo(object obj)
        {
            Eleve ce = obj as Eleve;
            int result = Prenom.CompareTo(ce.Prenom);
            if (result != 0)
                return result;
            result = Nom.CompareTo(ce.Nom);
            if (result != 0)
                return result;
            result = DateDeNaissance.CompareTo(ce.DateDeNaissance);
            return result;
        }

    }
}
