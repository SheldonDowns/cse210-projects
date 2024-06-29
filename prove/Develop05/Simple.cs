public class SimpleGoal : Goal
{
    public SimpleGoal() { }

    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        if (!IsCompleted())
        {
            MarkCompleted();
            return GetPoints();
        }
        return 0;
    }
}