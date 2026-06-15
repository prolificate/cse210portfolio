public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private int _amountCompleted;

    public ChecklistGoal(string name,
                         string description,
                         int points,
                         int target,
                         int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        int earned = GetPoints();

        if (_amountCompleted == _target)
        {
            earned += _bonus;
        }

        return earned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "X" : " ";

        return $"[{status}] {GetName()} -- Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()}";
    }
}