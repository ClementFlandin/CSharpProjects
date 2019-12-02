using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_04_12_MiniProjet2_CentreFormation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenetreEleves());
        }
    }
}

//Mini Projet 2 (Etape 1) - Créer un formulaire Windows connecté à une base de données
//_______________________________________________________________________________________


//    En vous basant sur le Mini Projet 1 dont le document de projet est ici :
//    https://docs.google.com/document/d/15DMxu3mlFuFCyuBOQs4l2b8NumND2-oNfBPCk1HAecE/edit?usp=sharing
    
//    vous devez créer une application qui stocke et gère les données
//    pour un organisme de formation.

//    Cette application bureau C# affiche un formulaire WinForms contenant :
    
//        * Des champs et labels pour rentrer les données de chaque élève
//        * Des boutons pour ajouter, modifier ou supprimer un élève de la base
//        * Un objet DataViewGrid pour afficher la liste d'élèves et les données


//    Les données sont stockées dans une base LiteDb (voir documentation MiniProjet 1)


//    Dans le mini projet, la classe CompteUtilisateur décrivait les données d'un
//    compte utilisteur et permettait de manipuler ces données dans le code C#
//    et dans la base de données.

//    De la même manière, l'application doit gérer les données d'élèves
//    d'un centre de formation :


//    Eleve
//        * Id (int)
//        * Prenom (string)
//        * Nom (string)
//        * DateNaissance (DateTime)
//        * Adresse (string)
//        * CodePostal (int)
//        * Ville (string)
//        * TelFixe (string)
//        * TelMobile (string)