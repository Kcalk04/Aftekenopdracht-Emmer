namespace Aftekenopdracht_Emmer;
public class Bucket : Container
{
    public Bucket(int capacity = 12) : base(capacity)
    {
        if (Capacity < 10 || Capacity > 2500)
        {
            Console.WriteLine($"ERROR! {Capacity} is invalid. Please submit a Capacity larger then 10 and smaller then 2500");
            throw new InvalidCapacityException();
        }

        Capacity = capacity;
        Content = 0;

    }
}