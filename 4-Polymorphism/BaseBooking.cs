namespace _4_Polymorphism;

public class BaseBooking
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public bool IsConfirm { get; private set; }

    public BaseBooking(int userId, DateTime date)
    {
        UserId = userId;
        Date = date;
        IsConfirm = false;
    }

    public void Confirm() => IsConfirm = true;

    public virtual void PrintSummary() => Console.WriteLine($"[Summary-4] Id:{Id}, Statue:{IsConfirm}");
}