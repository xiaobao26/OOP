namespace _5_Abstraction.Inheritance_Based_Abstraction;

public class FlightBooking: BaseBooking
{
    public string FlightNumber { get; set; }

    public FlightBooking(int userId, DateTime date, string flightNumber) : base(userId, date)
    {
        UserId = userId;
        Date = date;
        FlightNumber = flightNumber;
    }

    public override void Confirm()
    {
        IsConfirm = true;
    }

    public override void PrintSummary()
    {
        Console.WriteLine($"[Flight-booking-5.1] {FlightNumber}");
    }
}