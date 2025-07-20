namespace DesignPatterns.PatternExamples.Structural.Decorator;

internal class Decorator: IPatternExample
{
    public void Demonstrate( )
    {
        Console.Title = "Decorator";
        Console.WriteLine( "Decorator Structural Design Pattern example\n" );

        var comeHomeByBus = new ComeHomeByBus( );
        var comeHomeByCar = new ComeHomeByCar( );

        var grosseriesDecorator = new ComeHomeBuyGrosseries( comeHomeByCar );
        Console.WriteLine( grosseriesDecorator.Describe );

        Console.WriteLine( );

        var drinksDecorator = new ComeHomeHaveDringWithFriends( comeHomeByBus );
        Console.WriteLine( drinksDecorator.Describe );
    }
}