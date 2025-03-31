namespace _5_Abstraction.Inheritance_Based_Abstraction;

public abstract class BaseBooking
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public bool IsConfirm { get;  set; }
    public DateTime Date { get; set; }

    public BaseBooking(int userId, DateTime date)
    {
        UserId = userId;
        Date = date;
        IsConfirm = false;
    }

    public abstract void Confirm();
    public abstract void PrintSummary();
}