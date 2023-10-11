namespace Aftekenopdracht_Emmer;

public class ContentOverFlowException : Exception
{
    public ContentOverFlowException(int Capacity, int amount) : base("ContainerCapacity exceeded please try again...")
    {
        int overflow = amount - Capacity;
        Console.WriteLine($"ContainerCapacity of {Capacity} exceeded by {overflow} please try again...");
    }

    
}