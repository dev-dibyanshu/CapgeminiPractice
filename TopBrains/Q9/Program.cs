using System;

public class Solution
{
    public static string EvaluateExpression(string expression)
    {
        // Check expression format
        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
        {
            return "Error:InvalidExpression";
        }

        // Validate numbers
        if (!int.TryParse(parts[0], out int a) ||
            !int.TryParse(parts[2], out int b))
        {
            return "Error:InvalidNumber";
        }

        string op = parts[1];

        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0)
                    return "Error:DivideByZero";

                return (a / b).ToString();

            default:
                return "Error:UnknownOperator";
        }
    }

    public static void Main()
    {
        Console.WriteLine(EvaluateExpression("10 + 5"));
        Console.WriteLine(EvaluateExpression("10 / 2"));
        Console.WriteLine(EvaluateExpression("10 / 0"));
        Console.WriteLine(EvaluateExpression("10 ^ 5"));
        Console.WriteLine(EvaluateExpression("ten + 5"));
        Console.WriteLine(EvaluateExpression("10+5"));
    }
}