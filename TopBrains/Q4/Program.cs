using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public record Student(string Name, int Score);

public class Solution
{
    public string BuildStudentJson(string[] items, int minScore)
    {
        List<Student> students = new List<Student>();

        foreach (string item in items)
        {
            string[] parts = item.Split(':');

            if (parts.Length == 2)
            {
                string name = parts[0];
                int score = int.Parse(parts[1]);

                students.Add(new Student(name, score));
            }
        }

        var result = students
            .Where(s => s.Score >= minScore)
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();

        return JsonSerializer.Serialize(result);
    }
}