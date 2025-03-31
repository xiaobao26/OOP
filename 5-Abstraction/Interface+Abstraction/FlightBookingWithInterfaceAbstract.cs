namespace _5_Abstraction.Interface_Abstraction;

public class FlightBookingWithInterfaceAbstract: BaseBookingWithInterfaceAbstract
{
    public string FlightNumber { get; set; }

    public FlightBookingWithInterfaceAbstract(int userId, DateTime date, string flightNumber) : base(userId, date)
    {
        UserId = userId;
        Date = date;
        FlightNumber = flightNumber;
        IsConfirmed = false;
    }

    public override void Confirm()
    {
        IsConfirmed = true;
    }

    public override void PrintSummary()
    {
        Console.WriteLine($"[FlightBooking-5.3] {FlightNumber}");
    }
}