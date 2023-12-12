// Derived class for Running activity
public class Running : Activity
{
    private double _distance; // Distance run in kilometers

    public Running(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Running ({_durationInMinutes} min): Distance {_distance} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => _distance / (_durationInMinutes / 60.0);
    public override double GetPace() => _durationInMinutes / _distance;
}