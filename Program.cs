using System;

namespace Part_6___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///variables 

            ///the prompter
            int minimum;
            int maximum;
            int userGuess;
            ///percent passing
            double numofScores = 0;
            double numofPassingScores = 0;
            double percentageofPassingScores = 0;
            double userInput;
            ///oddsum
            double userNumber;
            double sumofOdds = 0;
            ///randomnumbers
            int randMin;
            int randMax;
            string randNumbers = "";
            Random rng = new Random();
          

            Console.WriteLine(@"
The Prompter

");

            Console.WriteLine("Please enter a minimum value (as an integer): ");
            while (!Int32.TryParse(Console.ReadLine(), out minimum))
            {
                Console.WriteLine("Please enter a valid integer: ");
            }
            Console.WriteLine("Please enter a maximum value (as an integer): ");
            while (!Int32.TryParse(Console.ReadLine(), out maximum))
            {
                Console.WriteLine("Please enter a valid integer: ");
            }

            Console.WriteLine("Now please enter a number in between " + minimum + " and " + maximum + ": ");
            while (!Int32.TryParse(Console.ReadLine(), out userGuess))
            {
                Console.WriteLine("Please enter a valid integer: ");
            }
            while (minimum > userGuess || maximum < userGuess)
            {
                Console.WriteLine("Please enter a number in between " + minimum + " and " + maximum + ": ");
                Int32.TryParse(Console.ReadLine(), out userGuess);
            }


            Console.WriteLine(@"

Percent Passing 

");

            Console.WriteLine(@"Please enter a score in between 0-100 and press enter.
When you've entered all the scores, type any negative number, then hit enter");
            while (Double.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput < 0)
                {
                    break;
                }
                else if (userInput > 70)
                {
                    numofPassingScores++;
                    numofScores++;
                    Console.WriteLine("Please enter the next score(or a negative number to cancel): ");
                }
                else
                {
                    numofScores++;
                    Console.WriteLine("Please enter the next score(or a negative number to cancel): ");
                }

            }

            percentageofPassingScores = (numofPassingScores / numofScores) * 100;
            Console.WriteLine(percentageofPassingScores + "% of your students passed!");


            Console.WriteLine(@"

OddSum

");

            Console.WriteLine("Please enter a number: ");
            while (!double.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("please enter a valid number: ");
            }

            for (int i = 1; i<= userNumber; i += 2)
            {
                sumofOdds += i;
            }
            Console.WriteLine(sumofOdds);


            Console.WriteLine(@"

RandomNumbers

");

            Console.WriteLine("please enter a minimum number using integers: ");
            while (!Int32.TryParse(Console.ReadLine(), out randMin))
            {
                Console.WriteLine("Please enter a valid minimum number: ");
            }
            Console.WriteLine("please enter a maximum number: ");
            while (!Int32.TryParse(Console.ReadLine(), out randMax))
            {
                Console.WriteLine("Please enter a valid maximum number: ");
            }
            for (int i = 0; i < 25; i += 1)
            {
                randNumbers += rng.Next(randMin, randMax) + ", ";
            }
            randNumbers = randNumbers.Remove(randNumbers.Length - 2) + ".";
            Console.WriteLine(randNumbers);




            Console.ReadLine();
        }
    }
}
