namespace Aftekenopdracht_Emmer;


    public class OilDrum : Container
    {
        public OilDrum( int capacity = 159) : base (Capacity: Container)
        {
            if (capacity == 159)
            {
                Capacity = capacity;
            }
            else
            {
                Console.WriteLine($"ERROR! {Capacity} is invalid. The capacity of an Oildrum can only be 159");
                throw new InvalidCapacityException();
            }
        }

        public static int Container { get; }
}

   