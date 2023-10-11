namespace Aftekenopdracht_Emmer;

public class InvalidCapacityException : Exception
{
    public InvalidCapacityException() : base ("Error! you submitted a wrong Capacity please consult the manual")
    {
        Console.WriteLine("Error! you submitted a wrong Capacity. please consult the manual");
    }
}