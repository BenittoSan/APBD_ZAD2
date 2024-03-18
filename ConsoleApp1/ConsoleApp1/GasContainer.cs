using ConsoleApp1.Cargo;

namespace ConsoleApp1;

public class GasContainer : BaseContainer<Gas>, IHazardNotifier
{
    private const string index = "G";
    public GasContainer(double loadedMass, double height, double weightContainer, string nrSeries, double capacity) : base(loadedMass, height, weightContainer, nrSeries, capacity)
    {
        this._nrSeries = index;
    }
    public static GasContainer Create(double loadMaxx, double height, double weightContainer, string nrSeries, double capacity)
    {
        return new GasContainer(loadMaxx, height, weightContainer, index, capacity);
    }

    public override void UnloadWeight()
    {
        loadedMass = 0;
    }

    public override void LoadWeight(Gas cargo)
    {
        if (cargo.Amount > capacity)
        {
            throw new OverfillException();
        }

        if (cargo.Amount > capacity* 0.8)
        {
            NotifyHazard("Loaded mass is over 80% of container capacity");
        }

        loadedMass = cargo.Amount;


    }

    public void NotifyHazard(string warning)
    {
        Console.WriteLine($"{nrSeries} : {warning}");
    }
}