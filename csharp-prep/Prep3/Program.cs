using System;
using System.Net;

Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 100);
int x = 0;


while (number != x)
{
    Console.Write("What is the magic number?");
    string guess = Console.ReadLine();
    x = int.Parse(guess);

    if (number > x)
    {
        Console.WriteLine("Higher"); 
    }
    else
    {
        Console.WriteLine("Lower");
    }
}   
Console.WriteLine("You guessed it!");