# Interface Segregation
Clients should not be forced to depend on interfaces they do not use.

```csharp
// ❌ "Fat" Interface
public interface IBooking 
{
    void Confirm();
    void Cancel();
    void SendReminder();
}
// That is fine
public class FlightBooking: IBooking
{
    public void Confirm() => {}
    public void Cancel() => {}
    public void SendReminder() => {}
}
// But this class only need Cancel mathod
public class TemporaryBooking : IBooking
{
    public void Confirm() =>  throw new NotSupportedException("Temporary cannot confirm.")
    public void Cancel() => ......
    public void SendReminder => throw new NotSupportedException("Temporary cannot send any Reminder.")
}
```

```csharp
// ✅ Split the Interface
// Clean, Focused, Scalable. Follows Interface Segregation perfectly
public interface IBookingConfirm 
{
    void Confirm();
}
public interface IBookingCancel
{
    void Cancel();
}
public interface IBookingSendReminder
{
    void SendReminder();
}

public class FlightBooking : IBookingConfirm, IBookingCancel, IBookingSendReminder
{
    public void Confirm()  {}
    public void Cancel() {}
    public void SendReminder() {}
}

public class TemporaryBooking: ICancel
{
    public void Cancel() {......}
}
```

```csharp
// ✅ Real Scenario
// Interfaces
public interface IEmailSender
{
    void SendEmail(string to, string message);
}
public interface ISmsSender
{
    void SendSms(string number, string message);
}
public interface ISendPush
{
    void SendPush(string deviceId, string  message);
}

// Services
public class EmailService: IEmailSender
{
    public void SendEmail(string to, string message) { ...... }
}
public class SmsServer: ISmsSender, ISendPush
{
    public void SendSms(string number, string message) { ...... }
    public void SendPush(string deviceId, string message) { ....... }
}

public class UserNotifier
{
    private readonly IEmailSender, _emailSender;
    private readonly ISmsSender, _smsSender;
    private readonly ISendPush _sendPush;
    
    public UserNotifier(IEmailSender, emailSender, ISmsSender, smsSender, ISendPush sendPush)
    {
        _emailSender = emailSender;
        _smsSender = smsSender;
        _sendPush = sendPush;
    }
    
    public void SendNotification(string userEmail, string message, string phoneNumber, string deviceId)
    {
        _emailSender.SendEmail(userEmail, message);
        _smsSender.SendSms(phoneNumber, message);
        _sendPush.SendPush(deviceId, message);
    }
}
```