using System;

class miniHangman
{
    static void Main()
    {
        string[] words = { "hangman", "programming", "csharp", "developer", "computer" };
        string wordToGuess = SelectRandomWord(words);
        char[] guessedWord = new char[wordToGuess.Length];

        for (int i = 0; i < wordToGuess.Length; i++)
        {
            guessedWord[i] = '_';
        }

        int attempts = 6;
        bool gameOver = false;

        Console.WriteLine("Welcome to Hangman!");

        while (!gameOver)
        {
            Console.WriteLine($"Word to guess: {new string(guessedWord)}");
            Console.WriteLine($"Attempts left: {attempts}");

            char guessedLetter = GetPlayerGuess();

            if (wordToGuess.Contains(guessedLetter))
            {
                UpdateGuessedWord(wordToGuess, guessedWord, guessedLetter);
            }
            else
            {
                attempts--;
            }

            if (attempts == 0 || new string(guessedWord) == wordToGuess)
            {
                gameOver = true;
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine($"Sorry, you ran out of attempts. The correct word was: {wordToGuess}");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the word!");
        }
    }

    static string SelectRandomWord(string[] words)
    {
        Random random = new Random();
        int index = random.Next(words.Length);
        return words[index];
    }

    static char GetPlayerGuess()
    {
        Console.Write("Enter a letter: ");
        char guessedLetter = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Move to the next line after the input
        return guessedLetter;
    }

    static void UpdateGuessedWord(string wordToGuess, char[] guessedWord, char guessedLetter)
    {
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (wordToGuess[i] == guessedLetter)
            {
                guessedWord[i] = guessedLetter;
            }
        }
    }
}
