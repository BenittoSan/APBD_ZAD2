using ConsoleApp1.Cargo;

namespace ConsoleApp1;

public class FerigeratedContainer : BaseContainer<Gas>, IHazardNotifier
{
    private const string index = "C";
    
    
    public FerigeratedContainer(double loadedMass, double height, double weightContainer, string nrSeries, double capacity) : base(loadedMass, height, weightContainer, nrSeries, capacity)
    {
        this._nrSeries = index;
    }

    public override void UnloadWeight()
    {
        loadedMass = 0;
    }

    public override void LoadWeight(Gas cargo)
    {
        


    }

    public void NotifyHazard(string warning)
    {
        Console.WriteLine($"{nrSeries} : {warning}");
    }
}