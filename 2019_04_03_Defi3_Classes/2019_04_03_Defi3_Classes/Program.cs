using System;

namespace _2019_04_03_Defi3_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quelles sont les longueur et largeur de votre table?");
            string[] dimensionsEntrees = (Console.ReadLine()).Split();
            
            Table maTable = new Table(double.Parse(dimensionsEntrees[0]), double.Parse(dimensionsEntrees[1]));
            maTable.Decrire();
        }
    }

    class Table
    {
        private double longueur;
        private double largeur;

        public Table(double longueur, double largeur)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public void Decrire()
        {
            Console.WriteLine("Cette table mesure : " + longueur + "x" + largeur);
        }
    }
}
