// Derived class for Swimming activity
public class Swimming : Activity
{
    private int _laps; // Number of laps swum
    private const double LapLengthMeters = 50; // Length of each lap in meters

    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Swimming ({_durationInMinutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }

    // Distance calculation in km
    public override double GetDistance() => _laps * LapLengthMeters / 1000.0; // Convert meters to kilometers
    public override double GetSpeed() => GetDistance() / (_durationInMinutes / 60.0);
    public override double GetPace() => _durationInMinutes / GetDistance();
}