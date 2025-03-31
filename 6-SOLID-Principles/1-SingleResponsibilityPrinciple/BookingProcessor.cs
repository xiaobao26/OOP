namespace _6_SOLID_Principles.SingleResponsibilityPrinciple;


/// <summary>
/// ❌ This is not Single Responsibility Principles
/// </summary>
// public class BookingProcessor
// {
//     public void Process(Booking booking)
//     {
//         Save(booking);
//         SendEmail(booking);
//         Log("Booking processed.");
//     }
//     
//     private void Save(Booking b) { }
//     private void SendEmail(Booking b) { }
//     private void Log(string msg) { }
// }

/// <summary>
/// ✅ This is the Single Responsebility Principle
/// </summary>
public class BookingRepository
{
    public void Save(Booking booking) {}
}

public class BookingEmailService
{
    public void SendConfirmEmail(Booking booking){}
}

public class BookingLog
{
    public void Log(string message){}
}