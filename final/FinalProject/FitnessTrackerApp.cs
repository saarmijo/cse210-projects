public class FitnessTrackerApp
{
    private List<User> _users;
    private List<WorkoutPlan> _workoutPlans;
    private List<DietPlan> _dietPlans;

    public FitnessTrackerApp()
    {
        _users = new List<User>();
        _workoutPlans = new List<WorkoutPlan>();
        _dietPlans = new List<DietPlan>();
    }

    public void AddUser(User user)
    {
        _users.Add(user);
        Console.WriteLine($"User '{user}' added to the fitness tracker app.");
    }

    public void RemoveUser(User user)
    {
        _users.Remove(user);
        Console.WriteLine($"User '{user}' removed from the fitness tracker app.");
    }

    public void AddWorkoutPlan(WorkoutPlan plan)
    {
        _workoutPlans.Add(plan);
        Console.WriteLine($"Workout plan added to the fitness tracker app.");
    }

    public void AddDietPlan(DietPlan plan)
    {
        _dietPlans.Add(plan);
        Console.WriteLine($"Diet plan added to the fitness tracker app.");
    }
}