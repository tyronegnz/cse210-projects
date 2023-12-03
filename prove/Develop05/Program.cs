using System;

// Entry point of the program
public class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager(); // Create an instance of GoalManager

        Console.WriteLine("Welcome to Goal Tracker!");

        bool exit = false;
        while (!exit)
        {
            // Display menu options
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. View goals and progress");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save progress");
            Console.WriteLine("6. Load progress");
            Console.WriteLine("7. Exit");

            string input = Console.ReadLine(); // Get user input
            switch (input)
            {
                case "1":
                    // Create a new goal based on user input
                    Console.WriteLine("Enter goal name:");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Select goal type (Simple, Eternal, Checklist):");
                    if (Enum.TryParse(Console.ReadLine(), out GoalType goalType))
                    {
                        int value = 0;
                        if (goalType != GoalType.Eternal)
                        {
                            Console.WriteLine("Enter the value for this goal:");
                            int.TryParse(Console.ReadLine(), out value);
                        }

                        if (goalType == GoalType.Checklist)
                        {
                            Console.WriteLine("Enter the target progress for this goal:");
                            int targetProgress = 0;
                            int.TryParse(Console.ReadLine(), out targetProgress);
                            manager.CreateGoal(goalName, goalType, value, targetProgress);
                        }
                        else
                        {
                            manager.CreateGoal(goalName, goalType, value);
                        }

                        Console.WriteLine("Goal created successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                    }
                    break;
                case "2":
                    // Record an event towards goal
                    Console.WriteLine("Enter the name of the goal you completed:");
                    string eventName = Console.ReadLine();
                    manager.RecordEvent(eventName);
                    break;
                case "3":
                    // Display all goals and their progress
                    manager.DisplayGoals();
                    break;
                case "4":
                    // Display user's current score
                    manager.DisplayScore();
                    break;
                case "5":
                    // Save user's progress to a file
                    manager.SaveProgress("progress.json");
                    break;
                case "6":
                    // Load user's progress from a file
                    manager.LoadProgress("progress.json");
                    break;
                case "7":
                    // Exit the program
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}