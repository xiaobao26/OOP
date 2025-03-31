namespace _2_Encapsulation;

/// <summary>
/// Encapsulation is about hiding internal state and exposing only safe,
/// controlled ways to interact with a class.
/// In my Booking class, I made properties like Id, Date, and IsConfirmed read-only, and created methods like Confirm() to control state changes.
/// </summary>
public class Booking
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public bool IsConfirmed { get; set; }
    
    // Constructor controls required data
    public Booking(int userId, DateTime date)
    {
        UserId = userId;
        Date = date;
        IsConfirmed = false;
    }
    
    // Controlled way to confirm booking
    public void Confirm()
    {
        IsConfirmed = true;
    }

    public void PrintSummary()
    {
        Console.WriteLine($"[SUMMARY] Id:{Id} State:{IsConfirmed}");
    }
}