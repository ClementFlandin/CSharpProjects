using System;
using System.IO;

namespace _2019_04_10_DefiException
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeur;
            Console.WriteLine("Veuillez rentrer un nombre");
            string valeurRentree = Console.ReadLine();
            try
            {
                valeur = Convert.ToInt32(valeurRentree);
                Console.WriteLine(String.Format("Vous avez rentré la valeur {0}!", valeur));
            }
            catch (FormatException fe)
            {
                string path = @"C:\Users\Clément\source\repos\2019_04_10_DefiException\2019_04_10_DefiException\bin\Debug\errors.log";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                FileStream fs = File.Create(path);
                fs.Close();
                File.WriteAllText(path, String.Format("Vous avez levé l'exception {0} qui stipule : {1} En effet vous avez rentré {2}.", fe.GetType(), fe.Message, valeurRentree));
            }
        }
    }
}
