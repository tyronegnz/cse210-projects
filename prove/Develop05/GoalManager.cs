using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Manages goals and user progress
public class GoalManager
{
    private List<Goal> goals = new List<Goal>(); // List to store goals
    private int userScore = 0; // User's total score

    // Create a new goal and add it to the list
    public void CreateGoal(string name, GoalType type, int value, int targetProgress = 0)
    {
        Goal newGoal = new Goal
        {
            Name = name,
            Type = type,
            Value = value,
            TargetProgress = targetProgress
        };

        goals.Add(newGoal);
    }

    // Record an event (progress towards a goal)
    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.CurrentProgress++;

            if (goal.Type == GoalType.Checklist && goal.CurrentProgress >= goal.TargetProgress)
            {
                userScore += goal.Value * goal.TargetProgress + 500;
                goal.Completed = true;
            }
            else
            {
                userScore += goal.Value;
            }
        }
    }

    // Display user's current score
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score: {userScore}");
    }

    // Display all goals and their progress
    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            string status = goal.Completed ? "Completed" : "Incomplete";
            if (goal.Type == GoalType.Checklist)
            {
                status += $" {goal.CurrentProgress}/{goal.TargetProgress} times";
            }
            Console.WriteLine($"{goal.Name}: {status}");
        }
    }

    // Save user's progress to a JSON file
    public void SaveProgress(string fileName)
    {
        try
        {
            string json = JsonSerializer.Serialize(new { Goals = goals, UserScore = userScore });
            File.WriteAllText(fileName, json);
            Console.WriteLine("Progress saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving progress: {ex.Message}");
        }
    }

    // Load user's progress from a JSON file
    public void LoadProgress(string fileName)
    {
        try
        {
            string json = File.ReadAllText(fileName);
            var data = JsonSerializer.Deserialize<dynamic>(json);
            goals = JsonSerializer.Deserialize<List<Goal>>(data.Goals.ToString());
            userScore = (int)data.UserScore;
            Console.WriteLine("Progress loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading progress: {ex.Message}");
        }
    }
}
