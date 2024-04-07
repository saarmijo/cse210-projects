public class WorkoutPlan
{
    private List<Exercise> _exercises;
    private TimeSpan _duration;
    private string _intensity;
    private string _goal;

    public WorkoutPlan(List<Exercise> exercises, TimeSpan duration, string intensity, string goal)
    {
        _exercises = exercises;
        _duration = duration;
        _intensity = intensity;
        _goal = goal;
    }

    public void CreateWorkoutPlan()
    {
        Console.WriteLine($"Workout plan created for {_duration.TotalMinutes} minutes.");
    }

    public void UpdateWorkoutPlan(List<Exercise> exercises, TimeSpan duration, string intensity, string goal)
    {
        _exercises = exercises;
        _duration = duration;
        _intensity = intensity;
        _goal = goal;
        Console.WriteLine($"Workout plan updated for {_duration.TotalMinutes} minutes.");
    }
}