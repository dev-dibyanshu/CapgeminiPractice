using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        string productName = " llapppptop bag ";

        // Remove extra spaces at beginning and end
        productName = productName.Trim();

        // Remove duplicate consecutive characters
        StringBuilder cleanedName = new StringBuilder();

        for (int i = 0; i < productName.Length; i++)
        {
            if (i == 0 || productName[i] != productName[i - 1])
            {
                cleanedName.Append(productName[i]);
            }
        }

        // Convert to TitleCase
        string result = System.Globalization.CultureInfo.CurrentCulture.TextInfo
            .ToTitleCase(cleanedName.ToString().ToLower());

        Console.WriteLine(result);
    }
}