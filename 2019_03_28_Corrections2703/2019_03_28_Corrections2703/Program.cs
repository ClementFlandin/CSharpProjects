using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculTVA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Créez un programme qui va convertir un prix hors taxes (HT)
            // en prix toutes taxes comprises (TTC)
            // Pour rappel : PrixTTC = PrixHT x TauxTVA
            // Si TVA à 20% alors TauxTVA = 0.20 (20/100)
            // Si TVA à 5% alors TauxTVA = 0.05 (5/100)

            // 1. Initialiser les variables
            float tva20 = 0.20f;
            float tva5 = 0.05f;
            // 2. Demander à l'utilisateur de taper un prix HT
            Console.WriteLine("Veuillez rentrer un prix HT!");
            string prixSaisi = Console.ReadLine();
            float prixHT = float.Parse(prixSaisi);

            // 3. Faire les calculs pour convertir le prix HT en prix TTC
            
            float prixTTC5 = prixHT * (1+tva5);
            float prixTTC20 = prixHT * (1+tva20);
            char euro = Convert.ToChar(8364);
            // 4. Afficher le résultat à l'utilisateur
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Si la TVA est de 5%, le prix TTC est : {prixTTC5} €, et si la TVA est de 20%, le prix TTC est : {prixTTC20} €!");
        }
    }
}
