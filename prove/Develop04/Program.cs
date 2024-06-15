using System;
using System.Collections.Generic;
using System.Threading;

namespace ActivityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Activity> activities = new Dictionary<string, Activity>
            {
                { "1", new BreathingActivity() },
                { "2", new ReflectionActivity() },
                { "3", new ListingActivity() }
            };

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");

                Console.Write("Choose an activity: ");
                string choice = Console.ReadLine();
                if (choice == "4")
                {
                    break;
                }
                else if (activities.ContainsKey(choice))
                {
                    activities[choice].Start();
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
    }
}
