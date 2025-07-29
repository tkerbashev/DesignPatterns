using static System.Console;

namespace DesignPatterns.Menu;

internal class SubMenu : IMenuItemStrategy
{
    private readonly ConsoleColor _background = BackgroundColor;
    private readonly ConsoleColor _foreground = ForegroundColor;

    public void Demonstrate( IMenuItem menuItem )
    {
        SelectOption( menuItem );
    }

    public void SelectOption( IMenuItem menuItem  )
    {
        var menuLines = InitialiseMenu( menuItem );

        if (menuLines.Length == 0)
        {
            return;
        }

        var iLine = 0;

        ConsoleKeyInfo c;
        do
        {
            SwapCursorColour( menuLines[ iLine ].Left, menuLines[ iLine ].Top );
            c = ReadKey( );
            ClearCursorPosition( menuLines[ iLine ].Left, menuLines[ iLine ].Top );
        }
        while (ProcessKeyInput( c.Key, menuLines, ref iLine ));

        SetCursorPosition( 1, menuLines.Length + 5);
    }

    private record MenuLine( int Left, int Top, IMenuItem MenuItem );

    private static MenuLine[ ] InitialiseMenu( IMenuItem menuItem )
    {
        Clear( );
        WriteLine( menuItem.Title );
        WriteLine( );

        var result = new MenuLine[menuItem.Children.Length ];

        for ( var iLine = 0; iLine < result.Length; iLine++ ) 
        {
            Write( $"{iLine + 1}. {menuItem.Children[iLine].Text} " );
            var (left, top) = GetCursorPosition( );
            result[ iLine] = new( Left: left, Top: top, menuItem.Children[ iLine ] );
            WriteLine();
        }

        WriteLine();
        WriteLine( "Use the Up and Down arrows to navigate." );
        WriteLine( "Press Enter to select or Escape to go back" );

        return result;
    }

    private static bool ProcessKeyInput( ConsoleKey key, MenuLine[ ] menuLines, ref int iLine ) 
    {
        switch ( key ) 
        {
            case ConsoleKey.Enter: menuLines[ iLine ].MenuItem.Strategy.Demonstrate( menuLines[ iLine ].MenuItem );
                _ = InitialiseMenu( menuLines[ iLine ].MenuItem.Parent! );
                break;
            case ConsoleKey.Escape: return false;
            case ConsoleKey.UpArrow: if (iLine > 0) { iLine--; };
                break;
            case ConsoleKey.DownArrow: if (iLine < menuLines.Length - 1) { iLine++; }; 
                break;
        }

        return true;
    }

    private void SwapCursorColour( int left, int top )
    {
        SetCursorPosition( left, top );
        BackgroundColor = _foreground;
        Write( ' ' );
        BackgroundColor = _background;
    }

    private static void ClearCursorPosition( int left, int top )
    {
        SetCursorPosition( left, top );
        Write( ' ' );
    }
}
