using System;

class Progarm
{

    static void Main(string[] args)
    {
        
        string greeting = "Howdy sandbox";
        Console.WriteLine($"{greeting}");

        while(true)
        {
            Console.Write("|\b");
            Thread.Sleep(500);
            Console.Write("\\\b");
            Thread.Sleep(500);
            Console.Write("-\b");
            Thread.Sleep(500);
            Console.Write("/\b");
            Thread.Sleep(500);
            Console.Write("-\b");
            Thread.Sleep(500);
        }


    }
}