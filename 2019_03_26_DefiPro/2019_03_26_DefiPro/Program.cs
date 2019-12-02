using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_03_26_DefiPro
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int firstNumber = rand.Next(1, 1000);
            int secondNumber = rand.Next(1, 1000);
            int numOp = rand.Next(1, 4);
            int result = 0;

            switch (numOp)
            {
                case (1):
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"L'opération est la suivante : {firstNumber} + {secondNumber}");
                    break;
                case (2):
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"L'opération est la suivante : {firstNumber} - {secondNumber}");
                    break;
                case (3):
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"L'opération est la suivante : {firstNumber} * {secondNumber}");
                    break;
                case (4):
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"L'opération est la suivante : {firstNumber} / {secondNumber}");
                    break;

            }
            Console.WriteLine("Quel est le résultat?");
            string input = Console.ReadLine();
            int resultInput = Convert.ToInt32(input);
            if (resultInput == result)
            {
                Console.WriteLine($"Bravo, la réponse était effectivement {result} !");
            }
            else
            {
                Console.WriteLine($"Dommage! La réponse était {result} !");
            }
            Console.ReadKey();
        }
    }
}
