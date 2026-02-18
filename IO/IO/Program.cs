using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>()
        {
            new Person(1, "Rahul", 21),
            new Person(2, "Anita", 22)
        };

        string csvPath = "people.csv";

        Console.WriteLine("=== CSV ===");

        using (StreamWriter writer = new StreamWriter(csvPath))
        {
            writer.WriteLine("Id,Name,Age");
            foreach (var p in people)
            {
                writer.WriteLine($"{p.Id},{p.Name},{p.Age}");
            }
        }
        Console.WriteLine("CSV Written");

        using (StreamWriter writer = new StreamWriter(csvPath, true))
        {
            writer.WriteLine("3,Karan,20");
        }
        Console.WriteLine("CSV Appended");

        Console.WriteLine("Reading CSV:");
        string[] lines = File.ReadAllLines(csvPath);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            Console.WriteLine($"Id={parts[0]}, Name={parts[1]}, Age={parts[2]}");
        }

        string jsonPath = "people.json";

        Console.WriteLine("\n=== JSON ===");

        string json = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonPath, json);
        Console.WriteLine("JSON Written");

        List<Person> fromFile = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(jsonPath)) 
                                ?? new List<Person>();
        fromFile.Add(new Person(3, "Priya", 23));

        string newJson = JsonSerializer.Serialize(fromFile, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonPath, newJson);
        Console.WriteLine("JSON Appended");

        Console.WriteLine("Reading JSON:");
        string readJson = File.ReadAllText(jsonPath);
        List<Person> finalPeople = JsonSerializer.Deserialize<List<Person>>(readJson) 
                                   ?? new List<Person>();

        foreach (var p in finalPeople)
        {
            Console.WriteLine($"Id={p.Id}, Name={p.Name}, Age={p.Age}");
        }
    }
}
