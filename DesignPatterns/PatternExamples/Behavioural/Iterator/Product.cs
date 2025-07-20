namespace DesignPatterns.PatternExamples.Behavioural.Iterator;

public class Product( string serialNumber, string colour )
{
    public string SerialNumber { get; set; } = serialNumber;
    public string Colour { get; set; } = colour;

    public override string ToString( )
    {
        return "Serial Number: " + SerialNumber + ", Colour: " + Colour;
    }
}
