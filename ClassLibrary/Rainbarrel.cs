namespace Aftekenopdracht_Emmer;

public class Rainbarrel : Container
{
    public Rainbarrel(int capacity) : base(capacity)
    {
        if (capacity != 80 && capacity != 100 && capacity != 120)
        {
            Console.WriteLine($"ERROR! {Capacity} is invalid. Please submit either 80, 100 or 120.");
            throw new InvalidCapacityException();

        }
        Capacity = capacity;
    }
}
