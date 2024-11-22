namespace C_Pro_Practice.HW2;

class Cello : MusicalInstrument
{
    public Cello() : base(
        "Cello", 
        "A larger stringed bow instrument.", 
        "The cello was created in Europe in the 17th century.") { }

    public override void Sound()
    {
        Console.WriteLine("Cello sound: Vuu-vuu-vuu!");
    }
}