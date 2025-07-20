namespace DesignPatterns.PatternExamples.Behavioural.Iterator;

public class ProductIterator( ProductCollection products ) : IProductIterator
{
    private int _currentRow, _currentColumn;
    private readonly int _totalRows = products.Height, _totalColumns = products.Width;

    public bool IsFinished => _currentRow >= _totalRows;

    public Product CurrentProduct => products.GetItem( _currentRow, _currentColumn );

    public Product First( )
    {
        _currentRow = 0;
        _currentColumn = 0;
        return CurrentProduct;
    }

    public Product? Next( )
    {
        _currentColumn++;
        if ( _currentColumn < _totalColumns )
        {
            return CurrentProduct;
        }
        _currentColumn = 0;
        _currentRow++;

        if (_currentRow < _totalRows)
        {
            return CurrentProduct;
        }

        return null;
    }
}
