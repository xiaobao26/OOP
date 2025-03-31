namespace _3_Inheritance;

public class HotelBooking: BaseBooking
{
    public string HotelName { get; set; }

    public HotelBooking(int userId, DateTime date, string hotelName) : base(userId, date)
    {
        UserId = userId;
        Date = date;
        HotelName = hotelName;
    }

    public override void PrintSummary()
    {
        base.PrintSummary();
        Console.WriteLine($"[HotelName]: {HotelName}");
    }
}