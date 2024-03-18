using ConsoleApp1.Cargo;

namespace ConsoleApp1;

public class FerigeratedContainer : BaseContainer<Product>, IHazardNotifier
{
    private const string index = "C";

    public FerigeratedContainer(double loadedMass, double height, double weightContainer, string nrSeries, double capacity, ProductType typeOfProduct, double temperature) : base(loadedMass, height, weightContainer, nrSeries, capacity)
    {
        TypeOfProduct = typeOfProduct;
        Temperature = temperature;
        _nrSeries = index;
    }

    public ProductType TypeOfProduct { get; set; }
    public double Temperature { get; set; }

    public void NotifyHazard(string warning)
    {
        Console.WriteLine($"{nrSeries} : {warning}");
    }

    

    public override void UnloadWeight()
    {
        throw new NotImplementedException();
    }

    public override void LoadWeight(Product cargo)
    {
        if (cargo.ProductType != TypeOfProduct)
        {
            throw new InvalidProductType();
            
        }

        if (Temperature < cargo.RequierTemperature)
        {
            Console.WriteLine("Temperature of Container is too low for this product");
            return;
        }

        if (cargo.Amount > capacity)
        {
            throw new OverfillException();
            
        }

        loadedMass = cargo.Amount;

    }
}