using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Voiture maVoiture = new Voiture("rouge");
            //maVoiture.Decrire();
            Console.WriteLine("What is your favorite car color?");
            string carColor = Console.ReadLine();
            Voiture myFavoriteCar = new Voiture(carColor);
            myFavoriteCar.Decrire();

            string violette = "Violette";
            string jaune = "Jaune";
            Voiture voitureViolette = new Voiture(violette);
            Voiture voitureJaune = new Voiture(jaune);
            voitureViolette.Decrire();
            voitureJaune.Decrire();
            
            Console.ReadLine();
        }
    }

    class Voiture
    {
        private string couleurDeVoiture;

        public Voiture(string couleur)
        {
            couleurDeVoiture = couleur;
        }

        public void Decrire()
        {
            Console.WriteLine("Cette voiture est de couleur : " + couleurDeVoiture);
        }
    }
}