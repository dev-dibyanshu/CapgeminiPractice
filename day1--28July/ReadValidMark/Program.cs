using System;

class Program
{
    static void Main(string[] args)
    {
        double mark1, mark2, mark3, mark4, mark5;

        // Subject 1
        while (true)
        {
            Console.Write("Enter Subject 1 Marks: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out mark1) && mark1 >= 0 && mark1 <= 100)
                break;

            Console.WriteLine("Invalid Marks! Enter a value between 0 and 100.");
        }

        // Subject 2
        while (true)
        {
            Console.Write("Enter Subject 2 Marks: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out mark2) && mark2 >= 0 && mark2 <= 100)
                break;

            Console.WriteLine("Invalid Marks! Enter a value between 0 and 100.");
        }

        // Subject 3
        while (true)
        {
            Console.Write("Enter Subject 3 Marks: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out mark3) && mark3 >= 0 && mark3 <= 100)
                break;

            Console.WriteLine("Invalid Marks! Enter a value between 0 and 100.");
        }

        // Subject 4
        while (true)
        {
            Console.Write("Enter Subject 4 Marks: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out mark4) && mark4 >= 0 && mark4 <= 100)
                break;

            Console.WriteLine("Invalid Marks! Enter a value between 0 and 100.");
        }

        // Subject 5
        while (true)
        {
            Console.Write("Enter Subject 5 Marks: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out mark5) && mark5 >= 0 && mark5 <= 100)
                break;

            Console.WriteLine("Invalid Marks! Enter a value between 0 and 100.");
        }

        // Calculations
        double total = mark1 + mark2 + mark3 + mark4 + mark5;
        double average = total / 5;
        double percentage = (total / 500) * 100;

        // Display Result
        Console.WriteLine("\n----- Student Result -----");
        Console.WriteLine($"Total Marks : {total}");
        Console.WriteLine($"Average     : {average}");
        Console.WriteLine($"Percentage  : {Math.Round(percentage, 2)}%");
    }
}