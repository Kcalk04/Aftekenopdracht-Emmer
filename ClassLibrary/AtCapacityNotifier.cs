namespace Aftekenopdracht_Emmer;

public class AtCapacityNotifier
{
    public void OnAtCapacity(Object source, EventArgs e)
    {
        Console.WriteLine("Container at capacity");
    }
}