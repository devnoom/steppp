using System;

class gtnumber
{
    static void Main()
    {
        Console.WriteLine("Welcome to Guess the Number Game!");

        
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        int attempts = 0;
        bool guessedCorrectly = false;

        do
        {
            Console.Write("Enter your guess (between 1 and 100): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userGuess))
            {
                attempts++;

                if (userGuess == randomNumber)
                {
                    guessedCorrectly = true;
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low. Try again!");
                }
                else
                {
                    Console.WriteLine("Too high. Try again!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (!guessedCorrectly);

        Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
    }
}
