using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            int guess;

            do
            {
                Console.Write("Guess a number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Too low, try again!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high, try again!");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                }

            } while (guess != number);
        }
    }
}
