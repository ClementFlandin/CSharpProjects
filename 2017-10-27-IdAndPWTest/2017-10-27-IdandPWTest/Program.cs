using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_27_IdandPWTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 1;
            Console.WriteLine("Enter your username and your password : ");
            Console.WriteLine("Default username and password are : username and password!");
            string idAndPW = Console.ReadLine();
            string[] subs = idAndPW.Split();

            while (subs[0] != "username" && subs[1]!="password" && count<3)
            {
                Console.WriteLine("Invalid username or password, try again!");
                idAndPW = Console.ReadLine();
                subs = idAndPW.Split();
                count++;
            }
            if (count == 3 && subs[0] != "username" && subs[1] != "password")
            {
                Console.WriteLine("You failed to log in!");
            }
            else
            {
                Console.WriteLine("Welcome username!");
            }
        }
    }
}
