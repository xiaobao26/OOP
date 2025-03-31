namespace _5_Abstraction.Inheritance_Based_Abstraction;

public class HotelBooking: BaseBooking
{
    public string HotelName { get; set; }

    public HotelBooking(int userId, DateTime date, string hotelName) : base(userId, date)
    {
        UserId = userId;
        Date = date;
        HotelName = hotelName;
    }
    
    public override void Confirm()
    {
        IsConfirm = true;
    }

    public override void PrintSummary()
    {
        Console.WriteLine($"[Hotel-Booking-5.1] hotelName:{HotelName}");
    }
}