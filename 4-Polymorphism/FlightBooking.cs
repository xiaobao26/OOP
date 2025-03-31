namespace _4_Polymorphism;

public class FlightBooking: BaseBooking
{
    public string FlightNumber { get; set; }

    public FlightBooking(int userId, DateTime date, string flightNumber) : base(userId, date)
    {
        UserId = userId;
        Date = date;
        FlightNumber = flightNumber;
    }

    public override void PrintSummary()
    {
        base.PrintSummary();
        Console.WriteLine($"[Flight-Number] {FlightNumber}");
    }
}