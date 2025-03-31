namespace _6_SOLID_Principles._2_OpenClosedPrinciple;

public class InvoiceService
{
    private readonly ITaxCalculator _taxCalculator;
    
    public InvoiceService(ITaxCalculator taxCalculator)
    {
        _taxCalculator = taxCalculator;
    }

    public decimal TotalAmount(decimal baseAmount)
    {
        var tax = _taxCalculator.TaxCalculator();
        return baseAmount * (1 + tax);
    }
}