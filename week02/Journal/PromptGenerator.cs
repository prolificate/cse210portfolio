public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most intrsting person I talked with today?",
        "What was the best part of my day?",
        "What made me smile today?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing over today,what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}