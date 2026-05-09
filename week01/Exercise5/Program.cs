using System;

class Program
{
    static void Main()
    {
        DisplayWelcomeMessage() ;
       string userName = PromptUserName();
       int userNumber = PromptUserNumber();

       int squaredNumber = SquareNumber(userNumber);

       DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to this program!.");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your full name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please what is your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the suare of your number is {square}.");
    }
}
