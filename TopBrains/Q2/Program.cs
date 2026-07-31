using System;

class Program
{
    static int[] MultiplicationTable(int n, int upto)
    {
        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }

    static void Main()
    {
        Console.Write("Enter number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter upto: ");
        int upto = Convert.ToInt32(Console.ReadLine());

        int[] result = MultiplicationTable(n, upto);

        Console.WriteLine("Multiplication Table Row:");

        foreach (int value in result)
        {
            Console.Write(value + " ");
        }

        Console.ReadKey();
    }
}