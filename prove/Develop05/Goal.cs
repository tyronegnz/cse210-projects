using System;

// Enum to define different types of goals
public enum GoalType
{
    Simple,
    Eternal,
    Checklist
}

// Represents a goal
[Serializable]
public class Goal
{
    // Properties of a goal
    public string Name { get; set; }
    public GoalType Type { get; set; }
    public int Value { get; set; }
    public int CurrentProgress { get; set; }
    public int TargetProgress { get; set; }
    public bool Completed { get; set; }
}
