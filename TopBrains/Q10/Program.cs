using System;

public class Solution
{
    public static int LargestInteger(int a, int b, int c)
    {
        if (a >= b && a >= c)
        {
            return a;
        }
        else if (b >= a && b >= c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }

    public static void Main()
    {
        Console.WriteLine(LargestInteger(10, 20, 30)); // 30
        Console.WriteLine(LargestInteger(50, 20, 30)); // 50
        Console.WriteLine(LargestInteger(10, 60, 30)); // 60
    }
}