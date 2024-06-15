using System;
using System.Collections.Generic;

namespace ActivityApp
{
    class ListingActivity : Activity
    {
        private static readonly List<string> Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
            : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        protected override void RunActivity()
        {
            Random rand = new Random();
            string prompt = Prompts[rand.Next(Prompts.Count)];
            Console.WriteLine(prompt);
            PauseWithAnimation("Prepare to start listing...", 5);

            DateTime startTime = DateTime.Now;
            List<string> items = new List<string>();

            while ((DateTime.Now - startTime).TotalSeconds < Duration)
            {
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                items.Add(item);
            }

            Console.WriteLine($"You listed {items.Count} items.");
        }
    }
}
