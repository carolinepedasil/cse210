public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0; // in km
    public override double GetSpeed() => (GetDistance() / LengthInMinutes) * 60;
    public override double GetPace() => LengthInMinutes / GetDistance();
}
