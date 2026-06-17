public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MM yyyy} {GetType().Name} ({_length}mins):" + $"Distance {GetDistance():F1}km," + $"Speed {GetSpeed():F1}kph" + $"Pace: {GetPace():F2}min per km";
    }
}