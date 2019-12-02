using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2019_03_29_Exo
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (File.Exists("C:\\Utilisateurs\\Clément\\Bureau\\test.txt"))
            //{
            //    string content = File.ReadAllText("C:\\Utilisateurs\\Clément\\Bureau\\test.txt", Encoding.UTF8);
            //    Console.WriteLine("Current content of file : ");
            //    Console.WriteLine(content);
            //}
            string path =@"C:\\"
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"C:\\Desktop\\test.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            //Console.WriteLine("Please enter text to add");
            //string newContent = Console.ReadLine();
            //File.WriteAllText("C:\\Utilisateurs\\Clément\\Bureau\\test.txt", newContent);

            Console.ReadKey();
        }

    }
}
//_____________________________________________________________

//DEFI PRO - LE JEU DES OPERATIONS MATHEMATIQUES

//Toi qui es déjà un pro du C#, relève le défi PRO et crée un
//programme qui :
//_____________________________________________________________

//    1. Prépare une opération mathématique avec :
//        2 nombres entiers aléatoires
//        1 opération aléatoire(addition, soustraction, multiplication
//            ou division)

//    2. Affiche l'opération choisie à l'utilisateur et attend
//        une entrée dans la console

//    3. Compare l'entrée utilisateur de la console avec le résultat
//        calculé par le programme

//    4. Indique à l'utilisateur s'il a bien répondu et, en cas de
//        mauvaise réponse, indique le résultat