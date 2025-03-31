namespace _6_SOLID_Principles.SingleResponsibilityPrinciple;

public abstract class Booking: IBooking
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public int UserId { get; private set; }
    public bool IsConfirmed { get; set; }
    public DateTime Date { get; set; }

    public Booking(int userId, DateTime date)
    {
        UserId = userId;
        Date = date;
    }

    public abstract void Confirm();
    public abstract void PrintMessage();

}