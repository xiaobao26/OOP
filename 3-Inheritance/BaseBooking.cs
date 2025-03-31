namespace _3_Inheritance;

public class BaseBooking
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public bool IsConfirmed { get; private set; }

    public BaseBooking(int userId, DateTime date)
    {
        UserId = userId;
        Date = date;
    }

    public void Confirm() => IsConfirmed = true;

    public virtual void PrintSummary() => Console.WriteLine($"[SUMMARY-3] Id:${Id} State:${IsConfirmed}");

}