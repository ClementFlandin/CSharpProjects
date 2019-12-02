using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_03_27_Defi3
{
    class Program
    {
        static void Main(string[] args)
        {
            //We instanciate a random method
            Random rand = new Random();
            Console.WriteLine("You must find 10 times the right multiplication answer!");
            
            //We intialise 5 variables: two integers that will stock two seperate random digits, 
            //the result that will store the input of the user
            //a boolean isFound will tell if the user inputs the right answer
            //& the numGame will tell the number of the game
            int randomNum1 = 0;
            int randomNum2 = 0;
            int result = 0;
            bool isFound = false;
            int numGame = 0;
            
            //We iterate at least once while the user inputs the correct answer, and while the user doesn't reach the 10th game
            do
            {
                //We initiate the 2 random digits
                randomNum1 = rand.Next(1, 10);
                randomNum2 = rand.Next(1, 10);

                //Asks the user what is the correct answer of the multiplication of the two random digits
                Console.WriteLine($"What is the result of {randomNum1}*{randomNum2} ?");

                //We store, after having converted it to an integer, the input in the result variable
                string input = Console.ReadLine();
                result = Convert.ToInt32(input);

                //We test if the user inputs the correct answer, if so we set isFound to true and the program tells the user the number of remaining games
                //and we increase he number of games by 1
                
                if (result == randomNum1 * randomNum2)
                {
                    isFound = true;
                    Console.WriteLine($"Congratulations! Keep going, still {10 - (numGame + 1)} correct answer(s) to give ;)");
                    numGame++;
                    //If numGame reached 10 we announce to the user he's won
                    if (numGame == 10)
                        Console.WriteLine("You win!");

                }

                //if the answer is wrong, isFound is set to false and the program tells the user he's lost, we therefore exit the do...while loop
                else
                {
                    isFound = false;
                    Console.WriteLine("You lose!");
                }
            } while (isFound && numGame<10);

            
            //We exit the program by pressing any key
            Console.ReadKey();
        }
    }
}
