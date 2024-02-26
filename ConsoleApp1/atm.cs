using System;

class atm
{
    static void Main()
    {
        // Initialize account balance
        double balance = 1000.0;

        while (true)
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your balance is: ${balance}");
                    break;

                case 2:
                    Console.Write("Enter the deposit amount: $");
                    double depositAmount = double.Parse(Console.ReadLine());
                    if (depositAmount > 0)
                    {
                        balance += depositAmount;
                        Console.WriteLine($"Deposit successful. Your new balance is: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount.");
                    }
                    break;

                case 3:
                    Console.Write("Enter the withdrawal amount: $");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    if (withdrawAmount > 0 && withdrawAmount <= balance)
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
