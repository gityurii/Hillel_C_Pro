namespace HW5;

public enum StoreType
{
    Grocery,
    Household,
    Clothing,
    Footwear
}

public class Store : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public StoreType Type { get; set; }
    private bool disposed;

    public Store(string name, string address, StoreType type)
    {
        Name = name;
        Address = address;
        Type = type;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Store Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Type: {Type}");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Free any managed resources here.
                Console.WriteLine($"Disposing managed resources of store: {Name}");
            }

            // Free any unmanaged resources here.
            Console.WriteLine($"Disposing unmanaged resources of store: {Name}");

            disposed = true;
        }
    }

    ~Store()
    {
        Dispose(false);
    }
}