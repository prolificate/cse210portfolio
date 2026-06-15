class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("-------------");
            manager.DisplayPlayerStats();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            Console.Write("\nSelect a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.DisplayGoals();
                    Console.ReadKey();
                    break;

                case "3":
                    manager.DisplayGoals();
                    Console.Write("\nWhich goal did you accomplish? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoal(index);
                    Console.ReadKey();
                    break;

                case "4":
                    manager.SaveGoals();
                    break;

                case "5":
                    manager.LoadGoals();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select goal type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(
                    new SimpleGoal(name, description, points));
                break;

            case "2":
                manager.AddGoal(
                    new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("Target completions: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus));
                break;
        }
    }
}