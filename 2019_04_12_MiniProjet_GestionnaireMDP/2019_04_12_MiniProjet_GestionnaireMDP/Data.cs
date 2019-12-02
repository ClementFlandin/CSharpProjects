using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;
using System.Text;
using System.Threading.Tasks;

namespace _2019_04_12_MiniProjet_GestionnaireMDP
{
    class Data
    {
        static public IEnumerable<CompteUtilisateur> RecupererListeComptes()
        {
            using(LiteDatabase db = new LiteDatabase("base.db"))
            {
                // On récupère et on retourne la table (collection) de comptes utilisateurs
                // déjà stockée
                return db.GetCollection<CompteUtilisateur>().FindAll();
            }
        }
        static public void AjouterCompte(CompteUtilisateur compte)
        {
            using(LiteDatabase db = new LiteDatabase("base.db"))
            {
                // On récupère la table (collection) de comptes utilisateurs
                // déjà stockée
                LiteCollection<CompteUtilisateur> listeComptes = db.GetCollection<CompteUtilisateur>();

                //On ajoute dans la base le nouveau compte utilisateur
                listeComptes.Insert(compte);
            }
        }
    }

    class CompteUtilisateur
    {
        public int Id { get; set; }
        public string NomSiteWeb { get; set; }
        public string NomUtilisateur { get; set; }
        public string HashMotDePasse { get; set; }
    }
}
