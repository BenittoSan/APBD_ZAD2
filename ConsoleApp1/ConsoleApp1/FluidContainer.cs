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
        if (cargo.Amount > loadMaxx)
        {
            
        }
    }

    public void NotifyHazard(string warning)
    {
        Console.WriteLine($"{nrSeries}: {warning}");
    }
}