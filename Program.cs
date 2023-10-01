using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int number = random.Next(1, 21);

            int tries = 0;
            int maxTries = 5;

            while (tries < maxTries)
            {
                Console.Write("Din gissning: ");
                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    bool isCorrect = CheckGuess(userGuess, number);

                    if (isCorrect)
                    {
                        Console.WriteLine("Wohoo! Du klarade det!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig input. Ange ett heltal.");
                }

                tries++;
            }

            if (tries == maxTries)
            {
                Console.WriteLine($"Tyvärr, du lyckades inte gissa talet på {maxTries} försök!");
            }
        }

        static bool CheckGuess(int guess, int target)
        {
            if (guess == target)
            {
                return true;
            }
            else if (guess > target)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");
            }
            else
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");
            }

            return false;
        }
    }
}    