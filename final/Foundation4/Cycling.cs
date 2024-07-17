class Cycling : Activity
{
    // Attributes
    private double speed; // Speed in km/h

    // Properties to encapsulate private fields
    public double Speed { get { return speed; } }

    // Constructor
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    // Methods
    public override double GetDistance() => (speed * Duration) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}
