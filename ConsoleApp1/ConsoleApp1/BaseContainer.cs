using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1;

public abstract class BaseContainer<T>
{
    
    
    private static int signature = 0;
    public double loadedMass { get; set; } // Cargo Max
    public double height { get; set; }
    public double weightContainer { get; set; }
    public string _nrSeries { get; set; }
    public double capacity { get; set; }

    protected BaseContainer(double loadedMass, double height, double weightContainer, string nrSeries, double capacity)
    {
        this.loadedMass = loadedMass;
        this.height = height;
        this.weightContainer = weightContainer;
        _nrSeries = nrSeries;
        this.capacity = capacity;
    }


    public string nrSeries
    {
        set
        {
            this._nrSeries = $"KON-{value}-{++signature}";
        }
        get
        {
            return this._nrSeries;
        }
    }

    public abstract void UnloadWeight();
    public abstract void LoadWeight(T cargo);
}