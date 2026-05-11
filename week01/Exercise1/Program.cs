using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your firstname? ");
          string first = Console.ReadLine();
        Console.Write("What is your lastname? ");
          string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}