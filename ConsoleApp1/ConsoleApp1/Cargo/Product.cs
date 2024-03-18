namespace ConsoleApp1.Cargo;

public class Product : Cargo
{
    public ProductType ProductType { get; set; }
    public double RequierTemperature { get; set; }
    
    public Product(string nameType, int amount, ProductType productType, double RequierTemperature) : base(nameType, amount)
    {
    }
}