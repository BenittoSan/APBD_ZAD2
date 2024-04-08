using ConsoleApp1.Cargo;

namespace ConsoleApp1;

public class FluidContainer : BaseContainer<Fluid>, IHazardNotifier
{
    private const string index = "L";
    public FluidContainer(double loadedMass, double height, double weightContainer, string nrSeries, double capacity) : base(loadedMass, height, weightContainer, nrSeries, capacity)
    {
        this._nrSeries = index;
    }

    public static FluidContainer Create(double loadMaxx, double height, double weightContainer, string nrSeries, double capacity)
    {
        return new FluidContainer(loadMaxx, height, weightContainer, index, capacity);
    }

    public override void UnloadWeight()
    {
        loadedMass = 0;
    }

    public override void LoadWeight(Fluid cargo)
    {
        if (cargo.Amount + loadedMass > capacity) throw new OverfillException();
        if (cargo.ProductSecurityType == ProductSecurityType.DANGEROUS && cargo.Amount > capacity*0.5)
        {
            NotifyHazard("You cant fill a container with dangerous cargo beyond 50% of the container capacity.");
        }
        
        if (cargo.Amount > capacity * 0.9 )
        {
            NotifyHazard("The container cannot be filled with more than 90% of fluid");
        }

        loadedMass = cargo.Amount;
    }

    public void NotifyHazard(string warning)
    {
        Console.WriteLine($"{nrSeries}: {warning}");
    }
}