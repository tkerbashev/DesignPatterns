namespace DesignPatterns.PatternExamples.Creational.AbstractFactory;

internal class AbstractFactory: IPatternExample
{
    public void Demonstrate( )
    {
        Console.Title = "Abstract Factory";

        var morningTeaFactory = new TeaFactory( );
        var morningTea = new MorningRoutine( morningTeaFactory );
        morningTea.Drink( );

        Console.WriteLine( );

        var morningCoffeeFactory = new CoffeeFactory( );
        var morningCoffee = new MorningRoutine( morningCoffeeFactory );
        morningCoffee.Drink( );
    }
}