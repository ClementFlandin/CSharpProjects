using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBibliotheque;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bonjour bonjour = new Bonjour();
            bonjour.DireBonjour();

            string prenom = ConfigurationManager.AppSettings["prenom"];
            string age = ConfigurationManager.AppSettings["age"];

            Console.WriteLine("{{0}} : / {1}", prenom, age);
        }
        
    }
}
