using System;
using System.Collections.Generic;

class StudentCollection
{
    private Dictionary<int, string> studentsById = new Dictionary<int, string>();
    private Dictionary<string, string> studentsByName = new Dictionary<string, string>();

    // Indexer: access by student ID (int)
    public string this[int id]
    {
        get
        {
            return studentsById.ContainsKey(id) ? studentsById[id] : "Student ID not found.";
        }
        set
        {
            studentsById[id] = value;
        }
    }

    // Overloaded Indexer: access by student name (string)
    public string this[string name]
    {
        get
        {
            return studentsByName.ContainsKey(name) ? studentsByName[name] : "Student Name not found.";
        }
        set
        {
            studentsByName[name] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentCollection students = new StudentCollection();

        // Using int indexer
        students[101] = "Alice";
        Console.WriteLine("ID 101: " + students[101]);

        // Using string indexer
        students["Bob"] = "Physics";
        Console.WriteLine("Name Bob's Subject: " + students["Bob"]);

        // Accessing non-existing keys
        Console.WriteLine("ID 999: " + students[999]);
        Console.WriteLine("Name Eve: " + students["Eve"]);
    }
}
