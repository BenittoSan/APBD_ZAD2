namespace ConsoleApp1.Cargo;

public class Fluid : Cargo
{
    public ProductType ProductType { get; set; }
    public Fluid(string nameType, int amount, ProductType productType) : base(nameType, amount)
    {
    }
    
    
}