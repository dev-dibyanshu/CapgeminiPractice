using System;

class Program
{
    static void Main()
    {
        int balance = GetInitialBalance();

        while (true)
        {
            int transaction = GetTransaction();

            balance = ProcessTransaction(balance, transaction);

            Console.WriteLine($"Current balance: {balance}");

            if (!ShouldContinue())
            {
                break;
            }
        }

        Console.WriteLine($"\nFinal balance: {balance}");
    }

    static int GetInitialBalance()
    {
        while (true)
        {
            Console.Write("Enter initial balance: ");

            if (int.TryParse(Console.ReadLine(), out int balance) && balance >= 0)
            {
                return balance;
            }

            Console.WriteLine("Please enter a valid non-negative amount.");
        }
    }

    static int GetTransaction()
    {
        while (true)
        {
            Console.Write("\nEnter transaction amount (+ credit / - debit): ");

            if (int.TryParse(Console.ReadLine(), out int transaction))
            {
                return transaction;
            }

            Console.WriteLine("Please enter a valid number.");
        }
    }

    static int ProcessTransaction(int balance, int transaction)
    {
        if (transaction >= 0)
        {
            return Credit(balance, transaction);
        }

        return Debit(balance, transaction);
    }

    static int Credit(int balance, int amount)
    {
        Console.WriteLine($"Amount credited: {amount}");

        return balance + amount;
    }

    static int Debit(int balance, int transaction)
    {
        int withdrawalAmount = -transaction;

        if (withdrawalAmount > balance)
        {
            Console.WriteLine("Low balance! Transaction cancelled.");
            return balance;
        }

        Console.WriteLine($"Amount debited: {withdrawalAmount}");

        return balance - withdrawalAmount;
    }

    static bool ShouldContinue()
    {
        while (true)
        {
            Console.Write("\nDo you want to continue? (y/n): ");

            string choice = Console.ReadLine()!.Trim().ToLower();

            if (choice == "y")
            {
                return true;
            }

            if (choice == "n")
            {
                return false;
            }

            Console.WriteLine("Please enter 'y' or 'n'.");
        }
    }
}
