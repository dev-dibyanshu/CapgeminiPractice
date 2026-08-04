using System;

public class Solution
{
    public string DisplayHeight(int heightCm)
    {
        if (heightCm < 150)
        {
            return "Short";
        }
        else if (heightCm < 180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter height in centimeters: ");

        int heightCm;

        while (!int.TryParse(Console.ReadLine(), out heightCm) || heightCm < 0 || heightCm > 300)
        {
            Console.WriteLine("Invalid input! Please enter a height between 0 and 300.");
            Console.Write("Enter height in centimeters: ");
        }

        Solution solution = new Solution();

        string result = solution.DisplayHeight(heightCm);

        Console.WriteLine($"Height Category: {result}");
    }
}