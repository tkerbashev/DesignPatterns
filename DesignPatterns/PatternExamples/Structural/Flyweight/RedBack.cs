namespace DesignPatterns.PatternExamples.Structural.Flyweight;

public class RedBack : ISpider
{
    private string _name = "Red Back Spider";
    private string _recommendation = "Dangerous! Stay away!";

    public RedBack()
    {
        Console.WriteLine( $"\n(Constructing a spider object for that {_name})" );
    }
    public string Spotted( string location )
    {
        return $"Found a {_name} in the {location}. \n{_recommendation}";
    }
}
