using _6_SOLID_Principles._2_OpenClosedPrinciple;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
        #region Single Responsibility Principle()SRP
        // 6.1:
        // Single Responsibility Principle (SRP): A class should have only one reason to change.
        // ❌ Bad Example: A class doing too much
        // public class BookingManager
        // {
        //     public void SaveBooking() { /* DB logic */ }
        //     public void SendConfirmationEmail() { /* Email logic */ }
        //     public void LogActivity() { /* Logging */ }
        // }
        #endregion

        #region Open / Closed Principles

        string countryName = "US";
        var taxCalculator = TaxCalculatorFactory.GetTaxCalculator(countryName);
        var invoiceService = new InvoiceService(taxCalculator);

        decimal baseAmount = 2.1m;
        decimal totalAmount = invoiceService.TotalAmount(baseAmount);
        Console.WriteLine($"[TotalAmount]: {totalAmount}");
        #endregion
        }
    }
}
