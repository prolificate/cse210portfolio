using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Benedict", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Robert Rodriguez", "Freactions", "Section 7.3", "Problems 8 - 19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomworkList());

        WritingAssignment assignment3 = new WritingAssignment("The cause of World War II","Mary Waters", "European History");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}