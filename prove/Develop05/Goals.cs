public abstract class Goal
{
    private string name;
    private int points;
    private bool completed;

    protected Goal() { }

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.completed = false;
    }

    public string GetName() => name;
    public int GetPoints() => points;
    public bool IsCompleted() => completed;
    public abstract int RecordEvent();

    protected void MarkCompleted() => completed = true;
}