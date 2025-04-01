# Liskov Substitution Principle
Objects of a base class should be replaceable with objects of its derived class without breaking the application

```csharp
// ✅ Good Example
public abstract class BaseBooking
{
    public bool IsConfirm { get; set; }
    public abstract void Confirm();
}
public class HotelBooking: BaseBooking
{
    public override void Confirm() => IsConfirm= true;
}
public class FlightBooking: BaseBooking
{
    public override void Confirm() => IsConfirm = true;
}

// ❌ Bad Example (Violation Liskov Substitution Principle )
public abstract class BaseBooking
{
    public bool IsConfirm { get; set; }
    public abstract void Confirm();
}

public class TemporaryBooking: BaseBooking
{
    public override void Confirm() => throw new Exception("Temporary booking cannot confirm.")
}
```

### If a child class doesn't support something from the base class, that is a sign of bad inheritance.
> **FIX**: Don't inherit
> 
> **FIX**: Refactor base class (Remove the Confirm from base class)
> 
> **FIX**: Use interfaces with smaller responsibilities (Interface Segregation)
