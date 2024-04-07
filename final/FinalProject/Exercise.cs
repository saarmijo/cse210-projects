public class Exercise
{
    private string _exerciseName;
    private string _description;
    private TimeSpan _duration;
    private int _caloriesBurned;

    public Exercise(string name, string description, TimeSpan duration, int caloriesBurned)
    {
        _exerciseName = name;
        _description = description;
        _duration = duration;
        _caloriesBurned = caloriesBurned;
    }

    public void LogExercise()
    {
        Console.WriteLine($"Logged exercise: {_exerciseName} - {_duration.TotalMinutes} minutes");
    }
}