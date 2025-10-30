using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Kyler", "C# Basics", "Section 7.3", "Problems 8-19");
        WritingAssignment writing = new WritingAssignment("Kyler", "C# Inheritance", "Learning Inheritance in C#");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());

    }
}