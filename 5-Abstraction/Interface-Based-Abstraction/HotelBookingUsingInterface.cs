namespace _5_Abstraction.Interface_Based_Abstraction;

public class HotelBookingUsingInterface: IBooking
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public bool IsConfirmed { get; set; }
    public DateTime Date { get; set; }
    public string HotelName { get; set; }


    public HotelBookingUsingInterface(int userId, DateTime date, string hotelName)
    {
        UserId = userId;
        Date = date;
        HotelName = hotelName;
        IsConfirmed = false;
    }

    public void Confirm()
    {
        IsConfirmed = true;
    }
    public void PrintSummary()
    {
        Console.WriteLine($"[Hotel-booking] {HotelName}");
    }
}