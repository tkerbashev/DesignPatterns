namespace DesignPatterns.PatternExamples.Structural.Flyweight;

internal class Flyweight: IPatternExample
{
    public void Demonstrate( )
    {
        Console.WriteLine( "Flyweight Structural Design Pattern example\n" );

        var spiderList = new SpiderFactory( );

        Console.WriteLine( spiderList.GetSpider( "Daddy-Long-Legs" ).Spotted( "kitchen" ) );
        Console.WriteLine( spiderList.GetSpider( "Daddy-Long-Legs" ).Spotted( "bathroom" ) );
        Console.WriteLine( spiderList.GetSpider( "Red Back Spider" ).Spotted( "shed" ) );
        Console.WriteLine( spiderList.GetSpider( "Black House Spider" ).Spotted( "garage" ) );
        Console.WriteLine( spiderList.GetSpider( "Garden orb weaving Spider" ).Spotted( "driveway" ) );
    }
}