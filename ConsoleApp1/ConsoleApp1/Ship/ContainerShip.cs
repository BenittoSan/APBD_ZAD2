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

    public void AddContainer( BaseContainer<Type> Container)
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

    public void RemoveContainer( string NrSeries )
    {
        foreach (var baseContainer in ContainerList)
        {
            if ( baseContainer._nrSeries.Equals(NrSeries) )
            {
                ContainerList.Remove(baseContainer);
            }
        }
        
    }

    public void SwapContainers(BaseContainer<Type> newContainer, string NrSeries)
    {
        AddContainer(newContainer);
        RemoveContainer(NrSeries);
    }

    private BaseContainer<Type> GetContainerFromShip(string NrSeries)
    {
        foreach (var baseContainer in ContainerList)
        {
            if (baseContainer._nrSeries.Equals(NrSeries))
            {
                return baseContainer;
            }
        }

        return null;
    }

    public void MoveContainerToOtherShip(string NrSeries, ContainerShip otherShip)
    {
        otherShip.AddContainer(this.GetContainerFromShip(NrSeries));
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