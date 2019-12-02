using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_28_FuncSpaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your sentence : ");
            string sentSent = Console.ReadLine();
            int spaces = NumSpaces(sentSent);
            Console.WriteLine("Your sentence \"{0}\" contains {1} spaces", sentSent, spaces);
        }

        public static int NumSpaces(string myString)
        {
            string[] newString = myString.Split(' ');
            return newString.Length-1;
        }
    }
}
