using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2017_12_11_ProjetCSharpLulu
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[,] couleurs = new ConsoleColor[50, 50];
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    couleurs[i, j] = ConsoleColor.Black;
                }
            }
            int[] position = { 20, 20 };
            int[] direction = { 1, 0 };
            ConsoleColor couleurFourmi = ConsoleColor.Magenta;
            Fourmi maFourmi = new FourmiDeLangton(position, direction, couleurFourmi);
            int cpt = 0;
            while (cpt<10)
            {
                for (int i = 0; i < 50; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        if (i == position[0] && j == position[1])
                        {
                            couleurs[i, j] = couleurFourmi;
                            Console.BackgroundColor = couleurFourmi;
                            Console.Write(' ');
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                maFourmi.chgtCouleurCase(couleurFourmi);
                maFourmi.deplacement(position, direction, couleurFourmi);
                Thread.Sleep(500);
                cpt++;
            }
        }
    }
}
