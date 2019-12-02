using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_02_LINQTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myTab = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = myTab.FindAll(number=>number%2==0);

            foreach(var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
