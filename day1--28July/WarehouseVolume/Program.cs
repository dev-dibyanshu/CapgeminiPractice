using System;

class Program
{
    static void Main(string[] args)
    {
        double length, width, height;

        // Read Length
        while (true)
        {
            Console.Write("Enter Length: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out length) && length > 0)
                break;

            Console.WriteLine("Invalid Length! Please enter a positive number.");
        }

        // Read Width 
        while (true)
        {
            Console.Write("Enter Width: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out width) && width > 0)
                break;

            Console.WriteLine("Invalid Width! Please enter a positive number.");
        }

        // Read Height
        while (true)
        {
            Console.Write("Enter Height: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out height) && height > 0)
                break;

            Console.WriteLine("Invalid Height! Please enter a positive number.");
        }

        // Calculate Volume
        double volume = length * width * height;

        // Display Result
        Console.WriteLine("\n----- Shipping Details -----");
        Console.WriteLine($"Length : {length}");
        Console.WriteLine($"Width  : {width}");
        Console.WriteLine($"Height : {height}");
        Console.WriteLine($"Volume : {Math.Round(volume, 2)}");
    }
}