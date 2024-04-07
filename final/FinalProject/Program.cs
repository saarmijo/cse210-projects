using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("JohnDoe", 30, 176, 70);
        FitnessTrackerApp fitnessApp = new FitnessTrackerApp();
        Log log = new Log();
        ProgressTracker progressTracker = new ProgressTracker(user);

        while (true)
        {
            Console.WriteLine("Fitness Tracker App Menu:");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Log Exercise");
            Console.WriteLine("3. Log Meal");
            Console.WriteLine("4. Create Workout Plan");
            Console.WriteLine("5. Create Diet Plan");
            Console.WriteLine("6. Display Log");
            Console.WriteLine("7. Display Progress");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter weight (in pounds): ");
                    double weight = double.Parse(Console.ReadLine());
                    Console.Write("Enter height (in inches): ");
                    double height = double.Parse(Console.ReadLine());

                    User newUser = new User(username, age, weight, height);
                    fitnessApp.AddUser(newUser);
                    break;

                case "2":
                    Console.Write("Enter exercise name: ");
                    string exerciseName = Console.ReadLine();
                    Console.Write("Enter exercise description: ");
                    string exerciseDesc = Console.ReadLine();
                    Console.Write("Enter exercise duration (in minutes): ");
                    int durationMinutes = int.Parse(Console.ReadLine());
                    Console.Write("Enter calories burned: ");
                    int caloriesBurned = int.Parse(Console.ReadLine());

                    Exercise newExercise = new Exercise(exerciseName, exerciseDesc, TimeSpan.FromMinutes(durationMinutes), caloriesBurned);
                    newExercise.LogExercise();
                    log.LogEntry($"Logged exercise: {exerciseName}");
                    break;

                case "3":
                    Console.Write("Enter meal name: ");
                    string mealName = Console.ReadLine();
                    Console.Write("Enter comma-separated ingredients: ");
                    List<string> ingredients = new List<string>(Console.ReadLine().Split(','));
                    Console.Write("Enter calories: ");
                    int calories = int.Parse(Console.ReadLine());
                    Console.Write("Enter protein (grams): ");
                    int protein = int.Parse(Console.ReadLine());
                    Console.Write("Enter carbs (grams): ");
                    int carbs = int.Parse(Console.ReadLine());
                    Console.Write("Enter fats (grams): ");
                    int fats = int.Parse(Console.ReadLine());

                    Meal newMeal = new Meal(mealName, ingredients, calories, protein, carbs, fats);
                    newMeal.LogMeal();
                    log.LogEntry($"Logged meal: {mealName}");
                    break;
                case "4":
                    Console.Write("Enter workout duration (in minutes): ");
                    int workoutDuration = int.Parse(Console.ReadLine());
                    Console.Write("Enter workout intensity: ");
                    string workoutIntensity = Console.ReadLine();
                    Console.Write("Enter workout goal: ");
                    string workoutGoal = Console.ReadLine();

                    List<Exercise> workoutExercises = new List<Exercise>();
                    while (true)
                    {
                        Console.Write("Add an exercise (Y/N)? ");
                        string addExercise = Console.ReadLine();
                        if (addExercise.ToLower() == "n") break;

                        Console.Write("Enter exercise name: ");
                        string ExerciseName = Console.ReadLine();
                        Console.Write("Enter exercise description: ");
                        string ExerciseDesc = Console.ReadLine();
                        Console.Write("Enter exercise duration (in minutes): ");
                        int DurationMinutes = int.Parse(Console.ReadLine());
                        Console.Write("Enter calories burned: ");
                        int CaloriesBurned = int.Parse(Console.ReadLine());

                        Exercise NewExercise = new Exercise(ExerciseName, ExerciseDesc, TimeSpan.FromMinutes(DurationMinutes), CaloriesBurned);
                        workoutExercises.Add(NewExercise);
                    }

                    WorkoutPlan newWorkoutPlan = new WorkoutPlan(workoutExercises, TimeSpan.FromMinutes(workoutDuration), workoutIntensity, workoutGoal);
                    newWorkoutPlan.CreateWorkoutPlan();
                    break;

                case "5":
                    Console.Write("Enter calorie goal: ");
                    int calorieGoal = int.Parse(Console.ReadLine());
                    Console.Write("Enter protein goal (grams): ");
                    int proteinGoal = int.Parse(Console.ReadLine());
                    Console.Write("Enter carb goal (grams): ");
                    int carbGoal = int.Parse(Console.ReadLine());
                    Console.Write("Enter fat goal (grams): ");
                    int fatGoal = int.Parse(Console.ReadLine());


                    List<Meal> dietMeals = new List<Meal>();
                    while (true)
                    {
                        Console.Write("Add a meal (Y/N)? ");
                        string addMeal = Console.ReadLine();
                        if (addMeal.ToLower() == "n") break;

                        Console.Write("Enter meal name: ");
                        string MealName = Console.ReadLine();
                        Console.Write("Enter comma-separated ingredients: ");
                        List<string> Ingredients = new List<string>(Console.ReadLine().Split(','));
                        Console.Write("Enter calories: ");
                        int Calories = int.Parse(Console.ReadLine());
                        Console.Write("Enter protein (grams): ");
                        int Protein = int.Parse(Console.ReadLine());
                        Console.Write("Enter carbs (grams): ");
                        int Carbs = int.Parse(Console.ReadLine());
                        Console.Write("Enter fats (grams): ");
                        int Fats = int.Parse(Console.ReadLine());

                        Meal NewMeal = new Meal(MealName, Ingredients, Calories, Protein, Carbs, Fats);
                        dietMeals.Add(NewMeal);
                    }

                    DietPlan newDietPlan = new DietPlan(dietMeals, calorieGoal, proteinGoal, carbGoal, fatGoal);
                    newDietPlan.CreateDietPlan();
                    break;


                case "6":
                    log.DisplayLog();
                    break;

                case "7":
                    progressTracker.DisplayProgress();
                    break;

                case "8":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}