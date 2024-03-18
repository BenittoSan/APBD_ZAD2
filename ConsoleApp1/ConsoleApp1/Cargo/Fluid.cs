namespace ConsoleApp1.Cargo;

public class Fluid : Cargo
{
    public ProductSecurityType ProductSecurityType { get; set; }
    public Fluid(string nameType, int amount, ProductSecurityType productSecurityType) : base(nameType, amount)
    {
    }
    
    
}