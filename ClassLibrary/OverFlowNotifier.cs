namespace Aftekenopdracht_Emmer;

public class OverFlowNotifier
{
    public void OnOverFlowing(object? source, EventArgs e)
    {
        Console.WriteLine("bruh");
        if (source is Container sourceObject) //source is container maar wordt sourceObject
        {
            Console.WriteLine("test");

            Console.WriteLine("Are you sure you want to continue filling if it overflows?");
            var yesOrNo = Console.ReadLine();
            if (yesOrNo.Equals("Yes") || yesOrNo.Equals("yes"))
            {
                Console.WriteLine("By how much would you like to have it overflow?");
                var overFlowAmount = Console.ReadLine();
                Console.WriteLine($"Not the choice i'd make but sure, overflowing by {overFlowAmount}");
                Console.WriteLine("Overflowing is being noticed");
                sourceObject.Content = sourceObject.Capacity;
                Console.WriteLine($"Has a capacity of: {sourceObject.Capacity}");
                Console.WriteLine("the Container contains: " + sourceObject.Content);
            }
            else
            {
                Console.WriteLine("Filling was canceled");


            }
        }
    }
}