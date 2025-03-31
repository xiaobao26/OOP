
using _4_Polymorphism;

List<BaseBooking> bookings = new List<BaseBooking>
{
    new HotelBooking(1, DateTime.UtcNow, "Hilton"),
    new FlightBooking(1, DateTime.Now, "FLY-88888"),
};

foreach (var booking in bookings)
{
    booking.Confirm();
    booking.PrintSummary();
}