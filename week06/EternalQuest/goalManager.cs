public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoal(int index)
    {
        int points = _goals[index].RecordEvent();

        _score += points;

        Console.WriteLine($"You earned {points} points!");
        Console.WriteLine($"Your score is now {_score}.");
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void DisplayPlayerStats()
    {
        int level = _score / 500 + 1;

        string title;

        if (_score >= 3000)
            title = "Legend";
        else if (_score >= 1000)
            title = "Hero";
        else if (_score >= 500)
            title = "Adventurer";
        else
            title = "Beginner";

        Console.WriteLine($"\nScore: {_score}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Title: {title}");
    }
}