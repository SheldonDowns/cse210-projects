public class User
{
    private List<Goal> goals;
    private int score;

    public User()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.GetName().Equals(goalName, StringComparison.OrdinalIgnoreCase))
            {
                score += goal.RecordEvent();
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            string status = goal.IsCompleted() ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                status += $" Completed {checklistGoal.GetCurrentCount()}/{checklistGoal.GetTargetCount()} times";
            }
            Console.WriteLine($"{status} {goal.GetName()} - {goal.GetPoints()} points");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {score}");
    }
}
