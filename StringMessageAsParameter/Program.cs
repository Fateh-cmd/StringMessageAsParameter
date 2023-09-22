using System;

class Program
{
    static string GetUserInput(string message)
    {
        Console.WriteLine(message);
        string text = Console.ReadLine();
        return text;
    }

    static void Main()
    {
        string message = "Please enter a number";
        string enteredText = GetUserInput(message);
        Console.WriteLine($"You entered: {enteredText}");
    }
}
