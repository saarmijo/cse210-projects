public class Meal
{
    private string _mealName;
    private List<string> _ingredients;
    private int _calories;
    private int _protein;
    private int _carbs;
    private int _fats;

    public Meal(string name, List<string> ingredients, int calories, int protein, int carbs, int fats)
    {
        _mealName = name;
        _ingredients = ingredients;
        _calories = calories;
        _protein = protein;
        _carbs = carbs;
        _fats = fats;
    }

    public void LogMeal()
    {
        Console.WriteLine($"Logged meal: {_mealName}");
    }
}