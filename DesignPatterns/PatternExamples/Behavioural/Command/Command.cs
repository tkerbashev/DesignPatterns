namespace DesignPatterns.PatternExamples.Behavioural.Command;

internal class Command: IPatternExample
{
    public void Demonstrate( )
    {
        Console.WriteLine( "Use the arrow keys to move around" );
        Console.WriteLine( "Press Enter or Escape to finish and reveal the current position" );
        Console.WriteLine( );
        Console.Write( "Now move: " );

        Surface surface = new( );
        PositionTracker tracker = new( new Logger( ), surface );
        CommandParameters parameters = new( surface );
        ConsoleKeyInfo response = new( );

        //Accept directions via the arrow keys and display them on the surface
        while (!(response.Key == ConsoleKey.Escape || response.Key == ConsoleKey.Enter))
        {
            response = Console.ReadKey( true );
            var command = tracker.AddCommand( response );
            tracker.DisplayMovement( command, parameters );
        }

        //Offer to present a list of the executed commands
        Console.SetCursorPosition( 0, Console.WindowHeight - 1 );
        Console.Write( "Press Enter to list your moves: " );
        Console.ReadLine( );

        tracker.ListExecutedCommands( );
    }
}