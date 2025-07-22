namespace DesignPatterns.PatternExamples.Structural.Decorator;

internal class Decorator: IPatternExample
{
    public void Demonstrate( )
    {
        Console.Title = "Decorator";
        Console.WriteLine( "Decorator Structural Design Pattern example\n" );

        var comeHomeByBus = new ComeHomeByBus( );
        var comeHomeByCar = new ComeHomeByCar( );

        var groceriesDecorator = new ComeHomeBuyGroceries( comeHomeByCar );
        Console.WriteLine( groceriesDecorator.Describe );

        Console.WriteLine( );

        var drinksDecorator = new ComeHomeHaveDrinkWithFriends( comeHomeByBus );
        Console.WriteLine( drinksDecorator.Describe );
    }
}