using System;



int user_number = 1;
List<int> numbers = new List<int>();
Console.WriteLine("Enter a list of numbers, type 0 when finished"); 

while (user_number != 0)
{
    Console.Write("Enter a number: ");
    string enter = Console.ReadLine();
    int number = int.Parse(enter);
    user_number = number;
    numbers.Add(number);
}

int sum = 0;
foreach(int number in numbers)
{
    sum +=  number;
}
Console.WriteLine($"Your sum is {sum}");

float average = ((float)sum) / (numbers.Count() - 1);
Console.WriteLine($"The average is {average}");

   int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
