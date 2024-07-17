class Swimming : Activity
{
    // Attributes
    private int laps; // Number of laps

    // Properties to encapsulate private fields
    public int Laps { get { return laps; } }

    // Constructor
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    // Methods
    public override double GetDistance() => (laps * 50) / 1000.0;
    public override double GetSpeed() => (GetDistance() / Duration) * 60;
    public override double GetPace() => Duration / GetDistance();
}
