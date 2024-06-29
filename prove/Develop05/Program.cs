using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Your Goals:");
            user.DisplayGoals();
            Console.WriteLine();
            user.DisplayScore();
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("1. Record an event");
            Console.WriteLine("2. Add a new goal");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter the name of the goal you completed: ");
                    string goalName = Console.ReadLine();
                    user.RecordEvent(goalName);
                    break;
                case "2":
                    AddNewGoal(user);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddNewGoal(User user)
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        switch (type)
        {
            case "1":
                user.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                user.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter the target count for the goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                user.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not added.");
                break;
        }
    }
}
