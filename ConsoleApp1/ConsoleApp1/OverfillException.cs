using System.Runtime.Serialization;

namespace ConsoleApp1;

public class OverfillException : Exception
{
    public OverfillException() 
    {
        Console.WriteLine("Cargo is bigger than Container capacity ");
    }
    

    
}