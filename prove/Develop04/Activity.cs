using System;
using System.Threading;

namespace ActivityApp
{
    abstract class Activity
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Duration { get; set; }

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Start()
        {
            DisplayStartMessage();
            Console.Write("Enter the duration of the activity in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            PrepareToBegin();
            RunActivity();
            DisplayEndMessage();
        }

        protected void DisplayStartMessage()
        {
            Console.WriteLine($"Starting Activity: {Name}");
            Console.WriteLine(Description);
        }

        protected void DisplayEndMessage()
        {
            PauseWithAnimation("Good job!", 2);
            PauseWithAnimation($"You have completed the {Name} activity for {Duration} seconds.", 2);
        }

        protected void PrepareToBegin()
        {
            PauseWithAnimation("Prepare to begin...", 3);
        }

        protected abstract void RunActivity();

        protected void PauseWithAnimation(string message, int pauseDuration)
        {
            Console.WriteLine(message);
            Spinner(pauseDuration);
        }

        private void Spinner(int duration)
        {
            char[] spinner = { '|', '/', '-', '\\' };
            int counter = 0;
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write(spinner[counter]);
                counter = (counter + 1) % spinner.Length;
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
}
