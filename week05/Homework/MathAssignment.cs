using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(string name,string topic, string textbookSection, string problem) : base (name, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string GetHomworkList()
    {
        return $"{_textbookSection} {_problem}";
    }
}