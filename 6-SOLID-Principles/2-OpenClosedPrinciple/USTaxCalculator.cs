using System.Security.Cryptography;

namespace _6_SOLID_Principles._2_OpenClosedPrinciple;

public class USTaxCalculator: ITaxCalculator
{
    public decimal TaxCalculator() => 0.1m;
}