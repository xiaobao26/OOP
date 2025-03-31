using _1_BasicClassAndObject;

var user = new User
{
    Age = 18,
    Email = "xiaobao.xue@example.com",
    Id = 1,
    Name = "xiaobao",
};
user.PrintInfo();


var booking = new Booking
{
    Date = DateTime.UtcNow,
    UserId = user.Id,
    Status = true
};
booking.PrintSummary();