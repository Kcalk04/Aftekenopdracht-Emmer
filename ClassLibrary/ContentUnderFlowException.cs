namespace Aftekenopdracht_Emmer;

public class ContentUnderFlowException : Exception
{
    public ContentUnderFlowException() : base("You cannot fill with a negative amount. Please try again...")
    {
        Console.WriteLine("You cannot fill with a negative amount. Please try again...");
    }

}