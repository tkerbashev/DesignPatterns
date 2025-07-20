namespace DesignPatterns.PatternExamples.Structural.Flyweight;

public class DaddyLongLegs : ISpider
{
    private string _name = "Daddy-Long-Legs";
    private string _recommendation = "Harmless. Leave it there.";
    public DaddyLongLegs()
    {
        Console.WriteLine( $"\n(Constructing a spider object for that {_name})" );
    }
    public string Spotted( string location )
    {
        return $"Found a {_name} in the {location}. \n{_recommendation}";
    }
}
