// Derived class for Cycling activity
public class Cycling : Activity
{
    private double _speed; // Speed in kilometers per hour

    public Cycling(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Cycling ({_durationInMinutes} min): Distance {GetDistance()} km, Speed: {_speed} km/h, Pace: {GetPace()} min per km";
    }

    public override double GetDistance() => _speed * (_durationInMinutes / 60.0);
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60.0 / _speed;
}