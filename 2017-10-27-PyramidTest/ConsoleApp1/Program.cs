using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine("Enter a width : ");
            int.TryParse(Console.ReadLine(), out int wid);

            for (int i = wid; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}
