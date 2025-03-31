# Open / Closed Principles
>#### Software entities should be open for extension, but closed for modification.
> 
>- ✅ should be able to add new behavior to the code.
> 
>- ❌ without having to modify existing logic.

### ❌ Violating OCP: if / switch everywhere
```csharp
public class InvoiceService
{
    public decimal CalculateTax(string country)
    {
        if (country == "UK") return 0.1m;
        if (country == "US") return 0.2m;
        return 0.15m;
    }
}
```

### ✅ Fix it with Abstraction (OCP-compliant)  
### one clean method — using Open/Closed Principle.
```csharp
// step1: 
public interface ITaxCalculator
{
    decimal Calculate();
}

// step2:
public class USTaxCalculator: ITaxCalculator
{
    public decimal Calculate() =>  0.1m;
}
public class UKTaxCalculator: ITaxCalculator
{
    public decimal Caluculate() =>  0.2m;
}

// step3:
public static class TaxCalculatorFactory
{
    public staic ITaxCalculator GetTaxCalculator(string countryName)
    {
        return countryName switch => 
        {
            "US" => UKTaxCalculator.Calculate(),
            "US" => USTaxCalculator.Calculate(),
            _ => throw new Exception("Country name is invalid.");
        }
    }
}

// step4:
public class InvoiceService
{
    private readonly ITaxCalculator _taxCalculator;
    
    public InvoiceService(ITaxCalculator taxCalculator)
    {
        _taxCalculator = taxCalculator;
    }
    
    public FinalAmount(decimal baseAmount)
    {
        var tax = _taxCalculator.Caluculate()
        return tax * baseAmount + baseAmount;
    }
}

// step5: 
string countryName = "US";
decimal baseAmount = 99.99;
var taxCalculator = TaxCalculatorFactory.GetTaxCalculator(countryName);

var invoiceService = InvoiceService(taxCalculator);
var totalAmount = invoiceService.FinalAmount(baseAmount);


```
