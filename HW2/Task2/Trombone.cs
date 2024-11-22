namespace C_Pro_Practice.HW2;

class Trombone : MusicalInstrument
{
    public Trombone() : base(
        "Trombone", 
        "A brass wind instrument.",
        "The trombone was created in the 15th century.") { }

    public override void Sound()
    {
        Console.WriteLine("Trombone sound: Ba-boom-boom!");
    }
}