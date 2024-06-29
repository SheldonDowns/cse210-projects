public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal() { }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public int GetCurrentCount() => currentCount;
    public int GetTargetCount() => targetCount;

    public override int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
            {
                MarkCompleted();
                return GetPoints() + bonusPoints;
            }
            return GetPoints();
        }
        return 0;
    }
}