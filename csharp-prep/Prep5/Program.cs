using System;
using System.Diagnostics;
using System.Reflection.Metadata;

class Program{



    static void Main(string[] args)
    {
        Welcome();
        string username = User_name();
        int usernumber = User_number();
        int square = Square_number(usernumber);
        End_messg(username, square);
    }



    static void Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }


    // Name
    static string User_name()
    {
        Console.Write("What is your name ");
        string name = Console.ReadLine();
        return name;
        
    }
    // Number

    static int User_number()        
    {
    Console.Write("What is your favorite number? ");
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
    }

    // Squared number
    static int Square_number(int number)
    {
        int Squr = number * number;
        return Squr;
    }
    // display number
    static void End_messg(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}






    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    //DisplayResult - Accepts the user's name and the squared number and displays them.