namespace _6_SOLID_Principles._2_OpenClosedPrinciple;

public static class TaxCalculatorFactory
{
    public static ITaxCalculator GetTaxCalculator(string countryName)
    {
        return countryName switch
        {
            "US" => new USTaxCalculator(),
            "UK" => new UKTaxCalculator(),
            _ => throw new Exception()
        };
    }
}