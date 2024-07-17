abstract class Activity
{
    // Attributes
    private DateTime date;
    private int duration; // Duration in minutes

    // Properties to encapsulate private fields
    public DateTime Date { get { return date; } }
    public int Duration { get { return duration; } }

    // Constructor
    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    // Methods
    public virtual double GetDistance() => 0; // To be overridden in derived classes
    public virtual double GetSpeed() => 0; // To be overridden in derived classes
    public virtual double GetPace() => 0; // To be overridden in derived classes

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Duration} min)- Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}
