namespace _1_BasicClassAndObject;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"[INFO] The use is{Name} and {Age} years old.");
    }
}