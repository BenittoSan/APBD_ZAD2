using ConsoleApp1.Cargo;

namespace ConsoleApp1;

public class FluidContainer : BaseContainer<Fluid>, IHazardNotifier
{
    private const string index = "L";
    public FluidContainer(double loadMaxx, double height, double weightContainer, string nrSeries, double capacity) : base(loadMaxx, height, weightContainer, nrSeries, capacity)
    {
    }

    public static FluidContainer Create(double loadMaxx, double height, double weightContainer, string nrSeries, double capacity)
    {
        return new FluidContainer(loadMaxx, height, weightContainer, nrSeries, capacity);
    }

    public override void UnloadWeight()
    {
        capacity = 0;
    }

    public override void LoadWeight(Fluid cargo)
    {
        if (cargo.Amount + loadMaxx > capacity) throw new OverfillException();
        if (cargo.ProductType == ProductType.DANGEROUS && cargo.Amount > loadMaxx*0.5)
        {
            NotifyHazard("You cant fill a container with dangerous cargo beyond 50% of the container capacity.");
        }
        
        if (cargo.Amount > loadMaxx * 0.9 )
        {
            NotifyHazard("The container cannot be filled with more than 90% of fluid");
        }

        loadMaxx = cargo.Amount;
    }

    public void NotifyHazard(string warning)
    {
        Console.WriteLine($"{nrSeries}: {warning}");
    }
}