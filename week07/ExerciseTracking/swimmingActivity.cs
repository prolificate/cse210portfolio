using System;
public class Swimming : Activity
{
    private int _lapping;

    public Swimming(DateTime date, int length, int lapping) : base (date, length)
    {
        _lapping = lapping;
    }

    public override double GetDistance()
    {
        return _lapping * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}