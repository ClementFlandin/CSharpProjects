using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_04_05_DefiFruits
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit monFruit1 = new Fruit("Banane", "Jaune", "Courbée");
            Fruit monFruit2 = new Fruit("Goyave", "Verte", "Ronde");

            Console.WriteLine(monFruit1.Decrire());
            Console.WriteLine(monFruit2.Decrire());

            Legume legume1 = new Legume("Tomate", "Rouge", "Ronde");
            Legume legume2 = new Legume("Carotte", "Orange", "Allongée");
            Legume legume3 = new Legume("Haricot", "Vert", "Incurvé");

            Console.WriteLine(legume1.Decrire());
            Console.WriteLine(legume2.Decrire());
            Console.WriteLine(legume3.Decrire());

            Console.ReadKey();
        }
    }
}
