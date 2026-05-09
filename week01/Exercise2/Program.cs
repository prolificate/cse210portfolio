using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade score? ");
          string score = Console.ReadLine();
          int mark = int.Parse(score);
         string grade = "";
        if (mark >= 90)
        {
            grade = "A";
        }
        else if (mark >= 80)
        {
            grade = "B";
        }
        else if (mark >= 70)
        {
            grade = "C";
        }
        else if (mark >= 60)
        {
            grade = "D";
        }
        else
        {
              grade = "F";
        }

        int last = mark % 10;
        string sign = "";
        if (last >= 7)
        {
            sign = "+";
        }
        else if (last < 3)
        {
            sign = "+";
        }

        if (grade == "A" && sign == "+")
        {
            sign = "";
        }
        if (grade == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is: {grade} {sign}");
        if (mark >= 70)
        {
            Console.Write("Congratulations you PASSED!");
        }
        else
        {
            Console.WriteLine("Try harder next time");
        }
    }
}