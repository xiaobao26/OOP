namespace _5_Abstraction.Interface_Based_Abstraction;

public class BaseBookingUsingInterface
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public bool IsConfirmed { get; set; }
    public DateTime Date { get; set; }

    public BaseBookingUsingInterface(int userId, DateTime date)
    {
        UserId = userId;
        Date = date;
        IsConfirmed = false;
    }
}