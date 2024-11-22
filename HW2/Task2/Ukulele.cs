namespace C_Pro_Practice.HW2;

class Ukulele : MusicalInstrument
{
    public Ukulele() : base(
        "Ukulele", 
        "A small four-stringed guitar-like instrument.",
        "The ukulele originated from Hawaii in the 19th century.") { }

    public override void Sound()
    {
        Console.WriteLine("Ukulele sound: Tring-tring!");
    }
}