namespace C_Pro_Practice.HW2;

class Violin : MusicalInstrument
{
    public Violin() : base(
        "Violin", 
        "A stringed bow instrument.",
        "The violin originated in Italy in the 16th century.") { }

    public override void Sound()
    {
        Console.WriteLine("Violin sound: Vii-vii!");
    }
}