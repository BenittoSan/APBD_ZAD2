namespace ConsoleApp1.Cargo;

public class InvalidProductType : Exception
{
    public InvalidProductType()
    {
        Console.WriteLine("Invalid product type.");
    }
}