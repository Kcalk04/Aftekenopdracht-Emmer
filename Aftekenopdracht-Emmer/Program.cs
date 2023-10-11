using Aftekenopdracht_Emmer;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the containers
        Bucket bucket = new Bucket(20);
        Rainbarrel rainBarrel = new Rainbarrel(120);
        OilDrum oilDrum = new OilDrum();
        var Overflownotifier = new OverFlowNotifier();
        var AtCapacityNotifier = new AtCapacityNotifier();

        bucket.OverflowingEvent += Overflownotifier.OnOverFlowing;
        bucket.AtCapacityEvent += AtCapacityNotifier.OnAtCapacity;
        
        bucket.Fill(22);
        Console.WriteLine($"Bucket content: {bucket.Content}");

        // Test filling and emptying the containers
        // bucket.Fill(20);
        // Console.WriteLine($"Bucket content: {bucket.Content}");
        // bucket.Empty();
        // Console.WriteLine($"Bucket content: {bucket.Content}");
        //
        // rainBarrel.Fill(500);
        // Console.WriteLine($"Rain barrel content: {rainBarrel.Content}");
        // rainBarrel.Empty();
        // Console.WriteLine($"Rain barrel content: {rainBarrel.Content}");
        //
        // oilDrum.Fill(150);
        // Console.WriteLine($"Oil drum content: {oilDrum.Content}");
        // oilDrum.Empty();
        // Console.WriteLine($"Oil drum content: {oilDrum.Content}");
        //
        // // Test filling a bucket with another bucket
        // Bucket bucket1 = new Bucket();
        // Bucket bucket2 = new Bucket();
        // bucket2.Fill(11);
        // bucket1.Fill(bucket2.Content);
        // Console.WriteLine($"Bucket 1 content: {bucket1.Content}");
    }
}

