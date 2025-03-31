namespace _5_Abstraction.Interface_Abstraction;

public class HotelBookingWithInterfaceAbstract: BaseBookingWithInterfaceAbstract
{
    public string HotelName { get; set; }

    public HotelBookingWithInterfaceAbstract(int userId, DateTime date, string hotelName) : base(userId, date)
    {
        UserId = userId;
        Date = date;
        HotelName = hotelName;
        IsConfirmed = false;
    }

    public override void Confirm()
    {
        IsConfirmed = true;
    }

    public override void PrintSummary()
    {
        Console.WriteLine($"[Hotel-Booking-5.3] {HotelName}");
    }
}