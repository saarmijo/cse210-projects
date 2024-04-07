using System;
using System.Collections.Generic;

public class ProgressTracker
{
    private User _user;
    private List<double> _weightHistory;
    private List<WorkoutPlan> _workoutPlans;
    private List<DietPlan> _dietPlans;

    public ProgressTracker(User user)
    {
        _user = user;
        _weightHistory = new List<double>();
        _workoutPlans = new List<WorkoutPlan>();
        _dietPlans = new List<DietPlan>();
    }

    public void LogWeight(double weightInPounds)
    {
        _weightHistory.Add(weightInPounds);
        Console.WriteLine($"Weight logged: {weightInPounds} pounds");
    }

    public void LogWorkout(WorkoutPlan workoutPlan)
    {
        _workoutPlans.Add(workoutPlan);
        Console.WriteLine($"Workout plan logged: {workoutPlan}");
    }

    public void LogMeal(DietPlan dietPlan)
    {
        _dietPlans.Add(dietPlan);
        Console.WriteLine($"Diet plan logged: {dietPlan}");
    }

    public void DisplayProgress()
    {
        Console.WriteLine($"Progress Tracker for {_user.Username}:");
        Console.WriteLine("Weight History:");
        foreach (var weight in _weightHistory)
        {
            Console.WriteLine($"- {weight} pounds");
        }

        Console.WriteLine("Workout Plans:");
        foreach (var plan in _workoutPlans)
        {
            Console.WriteLine($"- {plan}");
        }

        Console.WriteLine("Diet Plans:");
        foreach (var plan in _dietPlans)
        {
            Console.WriteLine($"- {plan}");
        }
    }
}
