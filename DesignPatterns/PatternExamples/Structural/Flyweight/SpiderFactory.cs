namespace DesignPatterns.PatternExamples.Structural.Flyweight;

public class SpiderFactory
{
    private readonly Dictionary<string, ISpider> _spiders = [];
    private readonly Lazy<UnknownSpider> _unknownSpider = new(() => new UnknownSpider());

    public ISpider GetSpider(string spiderType)
    {
        if (_spiders.TryGetValue( spiderType, out ISpider? value ))
        {
            Console.WriteLine($"\n(Re-using the {spiderType})");
            return value;
        }

        switch ( spiderType ) 
        {
            case "Daddy-Long-Legs":
                _spiders.Add(spiderType, new DaddyLongLegs());
                return _spiders[spiderType];
            case "Red Back Spider":
                _spiders.Add( spiderType, new RedBack( ) );
                return _spiders[ spiderType ];
            default:
                return _unknownSpider.Value;
        }
    }
}
