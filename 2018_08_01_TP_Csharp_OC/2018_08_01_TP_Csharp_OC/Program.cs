using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_08_01_TP_Csharp_OC
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            AfficherMenu();
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            while (consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2 && consoleKeyInfo.Key != ConsoleKey.NumPad1 && consoleKeyInfo.Key != ConsoleKey.NumPad2)
            {
                AfficherMenu();
                consoleKeyInfo = Console.ReadKey(true);
            }
            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
                Jeu1();
            else
                Jeu2();
        }

        private static void AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine("Veuillez choisir votre mode de jeu : ");
            Console.WriteLine("\t -1. Contre des monstres.");
            Console.WriteLine("\t -2. Contre le boss.");
        }
        private static void Jeu1()
        {
            Joueur clem = new Joueur(150);
            int faciles = 0;
            int difficiles = 0;
            while (clem.EstVivant)
            {
                MonstreFacile monstre = Monstre();
                while (monstre.EstVivant && clem.EstVivant)
                {
                    clem.Attaquer(monstre);
                    if (monstre.EstVivant)
                        monstre.Attaquer(clem);
                }
                if (clem.EstVivant)
                {
                    if (monstre is MonstreDifficile)
                        difficiles++;
                    else
                        faciles++;
                }
                else
                {
                    Console.WriteLine("Vous êtes mort " + Environment.UserName + ", snif!");
                }
            }
            Console.WriteLine("Bravo !!! Vous avez tué {0} monstres faciles et {1} monstres difficiles. Vous avez {2} points.", 
                faciles, difficiles, faciles + difficiles * 2);
        }

        private static void Jeu2()
        {
            Joueur clem = new Joueur(150);
            Boss boss = new Boss(250);
            while(boss.EstVivant && clem.EstVivant)
            {
                clem.AttaquerBoss(boss);
                if (boss.EstVivant)
                    boss.Attaquer(clem);
            }
            if (clem.EstVivant)
            {
                Console.WriteLine("Bravo " + Environment.UserName + "! Vous avez vaincu le boss de fin!");
            }
            else
            {
                Console.WriteLine("Zut " + Environment.UserName + "! Vous avez été tué par le boss! Recommencez!");
            }
        }
        private static MonstreFacile Monstre()
        {
            if (random.Next(2) == 0)
                return new MonstreFacile();
            else
                return new MonstreDifficile();
        }
    }
}
