public class DietPlan
{
    private List<Meal> _meals;
    private int _calorieGoal;
    private int _proteinGoal;
    private int _carbGoal;
    private int _fatGoal;

    public DietPlan(List<Meal> meals, int calorieGoal, int proteinGoal, int carbGoal, int fatGoal)
    {
        _meals = meals;
        _calorieGoal = calorieGoal;
        _proteinGoal = proteinGoal;
        _carbGoal = carbGoal;
        _fatGoal = fatGoal;
    }

    public void CreateDietPlan()
    {
        Console.WriteLine($"Diet plan created with calorie goal of {_calorieGoal} calories.");
    }

    public void UpdateDietPlan(List<Meal> meals, int calorieGoal, int proteinGoal, int carbGoal, int fatGoal)
    {
        _meals = meals;
        _calorieGoal = calorieGoal;
        _proteinGoal = proteinGoal;
        _carbGoal = carbGoal;
        _fatGoal = fatGoal;
        Console.WriteLine($"Diet plan updated with calorie goal of {_calorieGoal} calories.");
    }
}