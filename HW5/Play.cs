namespace HW5;

public class Play : IDisposable
{
    public string Title { get; set; }
    public string AuthorFullName { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    private bool disposed = false;

    public Play(string title, string authorFullName, string genre, int year)
    {
        Title = title;
        AuthorFullName = authorFullName;
        Genre = genre;
        Year = year;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"PLay Title: {Title}");
        Console.WriteLine($"    Author: {AuthorFullName}");
        Console.WriteLine($"    Genre: {Genre}");
        Console.WriteLine($"    Year: {Year}");
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
                Console.WriteLine($"Disposing managed resources of play: {Title}");
            }

            // Free any unmanaged resources here.
            Console.WriteLine($"Disposing unmanaged resources of play: {Title}");

            disposed = true;
        }
    }

    ~Play()
    {
        Dispose(false);
        Console.WriteLine($"Destructor finished with play: {Title}");
    }
}