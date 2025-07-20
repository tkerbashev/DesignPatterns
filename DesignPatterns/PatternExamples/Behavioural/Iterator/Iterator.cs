namespace DesignPatterns.PatternExamples.Behavioural.Iterator;

internal class Iterator: IPatternExample
{
    public void Demonstrate( )
    {
        var products = new Product[ 2, 3 ];
        products[ 0, 0 ] = new Product( "S12", "white" );
        products[ 0, 1 ] = new Product( "S54", "yellow" );
        products[ 0, 2 ] = new Product( "S92", "red" );
        products[ 1, 0 ] = new Product( "S67", "green" );
        products[ 1, 1 ] = new Product( "S98", "blue" );
        products[ 1, 2 ] = new Product( "S28", "gray" );

        ProductCollection collection = new( products );
        var iterator = collection.GetIterator( );
        Console.WriteLine( "Here are all the elements of the collectioon:" );
        while (!iterator.IsFinished)
        {
            Console.WriteLine( iterator.CurrentProduct.ToString( ) );
            iterator.Next( );
        }
    }
}