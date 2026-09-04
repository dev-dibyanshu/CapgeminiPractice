using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter first word: ");
        string firstWord = Console.ReadLine()!;

        Console.Write("Enter second word: ");
        string secondWord = Console.ReadLine()!;

        string result = RemoveCommonConsonants(firstWord, secondWord);

        result = RemoveConsecutiveDuplicates(result);

        Console.WriteLine($"Final result: {result}");
    }

    static string RemoveCommonConsonants(string firstWord, string secondWord)
    {
        StringBuilder result = new StringBuilder();

        foreach (char character in firstWord)
        {
            char lowerCharacter = char.ToLower(character);

            if (IsVowel(lowerCharacter))
            {
                result.Append(character);
                continue;
            }

            if (!secondWord.ToLower().Contains(lowerCharacter))
            {
                result.Append(character);
            }
        }

        return result.ToString();
    }

    static string RemoveConsecutiveDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        StringBuilder result = new StringBuilder();

        result.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                result.Append(input[i]);
            }
        }

        return result.ToString();
    }

    static bool IsVowel(char character)
    {
        return character == 'a' ||
               character == 'e' ||
               character == 'i' ||
               character == 'o' ||
               character == 'u';
    }
}