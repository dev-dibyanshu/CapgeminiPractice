using System;
using System.IO;
using System.Linq;

class Program
{
    private const string InputFile = "log.txt";
    private const string OutputFile = "error.txt";

    static void Main()
    {
        if (!File.Exists(InputFile))
        {
            Console.WriteLine($"File '{InputFile}' was not found.");
            return;
        }

        string[] logs = File.ReadAllLines(InputFile);

        string[] errorLogs = logs
            .Where(log => log.StartsWith("ERROR:", StringComparison.OrdinalIgnoreCase))
            .ToArray();

        File.WriteAllLines(OutputFile, errorLogs);

        Console.WriteLine($"ERROR logs have been saved to '{OutputFile}'.");
    }
}
