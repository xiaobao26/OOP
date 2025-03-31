namespace _5_Abstraction.Interface_Abstraction;

public abstract class BaseBookingWithInterfaceAbstract: IBooking
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public bool IsConfirmed { get; set; }

    public BaseBookingWithInterfaceAbstract(int userId, DateTime date)
    {
        UserId = userId;
        Date = date;
        IsConfirmed = false;
    }
    public abstract void Confirm();
    public abstract void PrintSummary();
}