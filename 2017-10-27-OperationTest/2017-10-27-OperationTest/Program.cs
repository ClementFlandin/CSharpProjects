using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_27_OperationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number : ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of operation :");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number : ");
            int second = int.Parse(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine("{0} + {1} = {2}", first, second, first + second);
            }
            else if (op == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", first, second, first - second);
            }
            else if (op == '*')
            {
                Console.WriteLine("{0} * {1} = {2}", first, second, first * second);
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", first, second, first / second);
            }
        }
    }
}
