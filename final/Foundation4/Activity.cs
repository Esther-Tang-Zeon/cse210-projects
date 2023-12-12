// Abstract base class representing a generic activity
public abstract class Activity
{
    public DateTime _date { get; private set; }
    public int _durationInMinutes { get; private set; }

    protected Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Summary in km
    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} ({_durationInMinutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}