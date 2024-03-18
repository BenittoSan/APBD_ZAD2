using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1;

public abstract class BaseContainer<T>
{
    
    /*private double loadMass; // w kg
    private double height; // w cm
    private double weightContainer; // w kg
    private string nrSeries;
    private double capacity; // w kg*/
    private static int signature = 0;
    public double loadMaxx { get; set; }
    public double height { get; set; }
    public double weightContainer { get; set; }
    public string _nrSeries { get; set; }
    public double capacity { get; set; }

    protected BaseContainer(double loadMaxx, double height, double weightContainer, string nrSeries, double capacity)
    {
        this.loadMaxx = loadMaxx;
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