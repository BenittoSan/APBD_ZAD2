namespace ConsoleApp1.Cargo;

public abstract class Cargo
{
    

    public string NameType { get; set; }
    public int Amount { get; set; }

    

    public Cargo(string nameType, int amount)
    {
        NameType = nameType;
        Amount = amount;
        
    }
}