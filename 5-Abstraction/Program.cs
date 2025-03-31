using _5_Abstraction.Inheritance_Based_Abstraction;
using _5_Abstraction.Interface_Abstraction;


#region Abstract Class Basic
List<BaseBooking> bookingsInAbstractionClass = new List<BaseBooking>
{
    new HotelBooking(1, DateTime.Now, "Holiton"),
    new FlightBooking(1, DateTime.Now, "FLY-99999"),
};

foreach (var booking in bookingsInAbstractionClass)
{
    booking.Confirm();
    booking.PrintSummary();
}
#endregion

#region Interface + Abstract Class
List<BaseBookingWithInterfaceAbstract> bookingsAbstractAndInterface = new List<BaseBookingWithInterfaceAbstract>
{
    new HotelBookingWithInterfaceAbstract(1, DateTime.Now, "xxx"),
    new FlightBookingWithInterfaceAbstract(1, DateTime.Now, "FLT-10000"),
};

foreach (var booking in bookingsAbstractAndInterface)
{
    booking.Confirm();
    booking.PrintSummary();
}
#endregion