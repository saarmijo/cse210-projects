public class User
{
    private string _username;
    private int _age;
    private double _weight;
    private double _height;
    private List<string> _fitnessGoals;
    public string Username
{
    get { return _username; }
    set { _username = value; }
}
    public User(string username, int age, double weight, double height)
    {
        _username = username;
        _age = age;
        _weight = weight;
        _height = height;
        _fitnessGoals = new List<string>();
    }

    public void SetFitnessGoals(List<string> goals)
    {
        _fitnessGoals = goals;
        Console.WriteLine($"{_username}'s fitness goals updated.");
    }

    public void UpdateProfile(int age, double weight, double height)
    {
        _age = age;
        _weight = weight;
        _height = height;
        Console.WriteLine($"{_username}'s profile updated.");
    }
}