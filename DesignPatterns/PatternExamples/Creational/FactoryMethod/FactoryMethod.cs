namespace DesignPatterns.PatternExamples.Creational.FactoryMethod;

internal class FactoryMethod: IPatternExample
{
    public void Demonstrate( )
    {
        Console.WriteLine( "Factory Method Creational Design Pattern example\n" );

        const int nClients = 10;
        Random rnd = new( );

        Console.WriteLine( nClients.ToString( ) + " clients came to our EV dealerships and here is what happenned:" );
        Console.WriteLine( );

        var dealerships = new List<EVShop>
{
    new TeslaShop(),
    new BYDShop()
};

        for (var iClient = 1; iClient <= nClients; iClient++)
        {
            var car = dealerships[ rnd.Next( 0, 2 ) ].AddCar( );

            Console.WriteLine( "Client " + iClient + " bought a " + car.Model );
        }
    }
}