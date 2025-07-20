namespace DesignPatterns.PatternExamples.Behavioural.Iterator;

public class ProductCollection( Product[ , ] products ) : IProductCollection
{
    public IProductIterator GetIterator( )
    {
        return new ProductIterator( this );
    }

    public int Height => products.GetLength( 0 );
    public int Width => products.GetLength( 1 );

    public Product GetItem( int row, int column ) 
    {
        return products[ row, column ];
    }
}
