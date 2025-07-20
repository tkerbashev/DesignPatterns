using static System.Console;

namespace DesignPatterns;

internal class PatternExample : IMenuItemStrategy
{
    private static readonly Lazy<PatternExample> _instance = new( ( ) => new PatternExample( ) );

    private PatternExample( )
    {
        // Prevent the default public constructor from being created
    }
    public static PatternExample Instance => _instance.Value;

    public void Demonstrate( IMenuItem menuItem )
    {
        Clear( );
        WriteLine( menuItem.Title );
        WriteLine( );

        menuItem.PatternExample.Demonstrate();

        WriteLine( );
        Write( "Press any key to return to the menu: " );
        _ = ReadKey( );
    }
}
