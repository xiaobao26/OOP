namespace _1_BasicClassAndObject;

public class Booking
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }

    public void PrintSummary()
    {
        Console.WriteLine($"[SUMMARY] Id:{Id} Status:{Status}");
    }
}