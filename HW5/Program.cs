using HW5;

public class Program
{
    public static void Main()
    {
        // Example 1
        using (var store = new Store("Fresh Market", "123 Main St", StoreType.Grocery))
        {
            store.PrintDetails();
        }

        // Example 2
        Console.WriteLine();
        var clothingStore = new Store("Fashion Hub", "456 Elm St", StoreType.Clothing);
        clothingStore.PrintDetails();
        clothingStore.Dispose();

        // Example 3
        Console.WriteLine();
        using (var store = new Store("Bookstore", "789 Pine St", StoreType.Household))
        {
            using (var play = new Play("Macbeth", "William Shakespeare", "Tragedy", 1606))
            {
                store.PrintDetails();
                play.PrintDetails();
            }
        }

        // Example 4
        Console.WriteLine();
        CreateAndDestroyPlay();

        // Forced call of GC
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("---GC invoked, destructor should have run.");
    }

    private static void CreateAndDestroyPlay()
    {
        var play = new Play("King Lear", "William Shakespeare", "Tragedy", 1606);
        play.PrintDetails();
    }
    
}

