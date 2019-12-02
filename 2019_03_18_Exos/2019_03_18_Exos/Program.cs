using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2019_03_18_Exos
{
    class Program
    {

        static void Main(string[] args)
        {
            
            
            //Working with LINQ!!


            //List<Famille> family = new List<Famille>() { new Famille { Name = "Aina", Age = 3 }, new Famille { Name = "Nadia", Age = 37 }, new Famille { Name = "Clement", Age = 31 }, new Famille { Name = "Audrey", Age = 3 } };

            //var ageAsc = family.GroupBy(membre => membre.Age);
            //foreach (var group in ageAsc)
            //{
            //    Console.WriteLine($"Les personnes suivantes ont : {group.Key} ans :");
            //    foreach (Famille fam in group)
            //    {
            //        Console.WriteLine(fam.Name);
            //    }
            //}
            //var names = new List<string>()
            //{
            //    "John Doe",
            //    "Jane Doe",
            //    "Jenna Doe",
            //    "Joe Doe"
            //};

            //// Get the names which are 8 characters or less, using LINQ
            //var shortNames = names.Where(name => name.Length <= 8);
            //// Order it by length
            //shortNames = shortNames.OrderBy(name => name.Length);
            //// Add a name to the original list
            //names.Add("Zoe Doe");

            //// Iterate over it - the query has not actually been executed yet!
            //// It will be as soon as we hit the foreach loop though!
            //foreach (var name in shortNames)
            //    Console.WriteLine(name);



            //CultureInfo usCulture = new CultureInfo("en-US");
            //XDocument xDoc = XDocument.Load("http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            //var cubeNodes = xDoc.Descendants().Where(n => n.Name.LocalName == "Cube" && n.Attribute("currency") != null).ToList();
            //var currencyRateItems = cubeNodes.Select(node => new
            //{
            //    Currency = node.Attribute("currency").Value,
            //    Rate = double.Parse(node.Attribute("rate").Value, usCulture)
            //});


            //int pageSize = 5, pageCounter = 0;
            //var pageItems = currencyRateItems.Take(pageSize);
            //while (pageItems.Count() > 0)
            //{
            //    foreach (var item in pageItems)
            //    {
            //        Console.WriteLine(item.Currency + ": " + item.Rate.ToString("N2", usCulture));
            //    }
            //    Console.WriteLine("Press any key to get the next items...");
            //    Console.ReadKey();
            //    pageCounter++;
            //    // Here's where we use the Skip() and Take() methods!
            //    pageItems = currencyRateItems.Skip(pageSize * pageCounter).Take(pageSize);
            //}
            //Console.WriteLine("Done!");


            /*Working with ExpandoObject
            dynamic user = new System.Dynamic.ExpandoObject();
            user.Name = "John Doe";
            user.Age = 42;

            foreach (KeyValuePair<string, object> kvp in user)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
            */

            /*Working with dates 
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToString("dd MMMM YY"));
            var xCulture = new System.Globalization.CultureInfo("en-UK");
            Console.WriteLine(DateTime.Now.ToString(xCulture.DateTimeFormat));
            */


            /*Working with strings:  string name = "Clement Flandin";
            int indexOfSpace = name.IndexOf(' ')+1;
            string lastName = name.Substring(indexOfSpace, (name.Length - indexOfSpace));
            Console.WriteLine(lastName);
            Console.WriteLine(name.Replace("Clement","Elsa"));
            */

            /*Working with char: 

            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //bool isValid = true;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char ch = name[i];
            //    if ((i==0)&&((!Char.IsLetter(ch)||(!Char.IsUpper(ch)))))
            //    {
            //        Console.WriteLine("First letter must be in uppercase!");
            //        isValid = false;
            //        break;
            //    }
            //    if (Char.IsDigit(ch))
            //    {
            //        Console.WriteLine("No digit is allowed!");
            //        isValid = false;
            //        break;
            //    }
            //}
            //if (isValid)
            //{
            //    Console.WriteLine($"Hello {name}!");
            //}

            //char ch = Console.ReadKey(true).KeyChar;
            //if (Char.IsDigit(ch))
            //{
            //    Console.WriteLine($"You entered : {ch}, thank you!");
            //}
            //else
            //{
            //    Console.WriteLine("I didn't get your entry!");
            //}
            */
        }


        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Veuillez rentrer le nombre de chevaux partant");
        //    //string chSt = Console.ReadLine();
        //    //int n = Convert.ToInt32(chSt);
        //    //Console.WriteLine("Combien voulez-vous jouer de chevaux?");
        //    //string chJouesStr = Console.ReadLine();
        //    //int p = Convert.ToInt32(chJouesStr);
        //    //int N = Factorielle(n);
        //    //int P = Factorielle(p);
        //    //int factNMoinsP = Factorielle(n - p);
        //    //float X = N / factNMoinsP;
        //    //float Y = X/P;
        //    //Console.WriteLine("Dans l'ordre : une chance sur " + X + ", et dans le désordre: une chance sur " + Y);


        //}

        //static int Factorielle(int n)
        //{
        //    int res=n;
        //    for (int i = 1; i < n; i++)
        //    {
        //        res *= i;
        //    }
        //    return res;
        //}
    }
}
