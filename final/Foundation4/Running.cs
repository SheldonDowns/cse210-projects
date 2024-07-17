class Running : Activity
{
    // Attributes
    private double distance; // Distance in kilometers

    // Properties to encapsulate private fields
    public double Distance { get { return distance; } }

    // Constructor
    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    // Methods
    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / Duration) * 60;
    public override double GetPace() => Duration / distance;
}
