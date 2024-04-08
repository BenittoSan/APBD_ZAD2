namespace ConsoleApp1.Ship;

public class ContainerShip : IHazardNotifier
{
    private LinkedList<BaseContainer<Type>> ContainerList { get; set; }
    private int MaxCountOfContainers;
    private double Speed;

    public ContainerShip(int maxCountOfContainers, double speed)
    {
        MaxCountOfContainers = maxCountOfContainers;
        Speed = speed;
        ContainerList = new LinkedList<BaseContainer<Type>>();

    }

    public void AddContainer(BaseContainer<Type> Container)
    {
        if (ContainerList.Count >= MaxCountOfContainers)
        {
            NotifyHazard("No more space for new Conainer");
        }
        ContainerList.AddLast(Container);
    }

    public void AddContainerList(LinkedList<BaseContainer<Type>> ListOfContainers)
    {
        foreach (var baseContainer in ListOfContainers)
        {
            AddContainer(baseContainer);
        }
    }

    public static void Main(string[] args)
    {
        LinkedList<BaseContainer<GasContainer>> a = new LinkedList<BaseContainer<GasContainer>>();
        
       // ship.ContainerList.AddLast(GasContainer.Create());
    }

    public void NotifyHazard(string warning)
    {
        Console.Write(warning);
    }
}