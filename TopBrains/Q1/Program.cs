using System;

class Program
{
    // Method 1: Swap using ref
    static void SwapUsingRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    // Method 2: Swap using out
    static void SwapUsingOut(int a, int b, out int x, out int y)
    {
        x = a + b;
        y = x - b;
        x = x - y;
    }

    static void Main()
    {
        int num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nOriginal Values:");
        Console.WriteLine($"Number1 = {num1}, Number2 = {num2}");

        // Method 1: ref
        SwapUsingRef(ref num1, ref num2);

        Console.WriteLine("\nAfter Swapping using ref:");
        Console.WriteLine($"Number1 = {num1}, Number2 = {num2}");

        Console.Write("\nEnter first number again: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number again: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Method 2: out
        SwapUsingOut(num1, num2, out num1, out num2);

        Console.WriteLine("\nAfter Swapping using out:");
        Console.WriteLine($"Number1 = {num1}, Number2 = {num2}");

        Console.ReadKey();
    }
}