namespace DesignPatterns.PatternExamples.Structural.Flyweight;

public class UnknownSpider : ISpider
{
    public UnknownSpider()
    {
        Console.WriteLine( $"\n(Constructing a generic spider object for all unknown spiders)" );
    }
    public string Spotted( string location )
    {
        return $"Found unknown type of spider in the {location}. \nTreat as dangerous!";
    }
}
