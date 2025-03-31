
using _3_Inheritance;

var bookingHotel = new HotelBooking(1, DateTime.UtcNow, "Big W");
bookingHotel.Confirm();
bookingHotel.PrintSummary();