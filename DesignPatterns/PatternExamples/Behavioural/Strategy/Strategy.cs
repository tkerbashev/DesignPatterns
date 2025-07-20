namespace DesignPatterns.PatternExamples.Behavioural.Strategy;

internal class Strategy: IPatternExample
{
    public void Demonstrate( )
    {
        var keepLeft = new KeepLeft( );
        var keepRight = new KeepRight( );

        Console.WriteLine( "Trying to get out of a maze:" );

        MazeNavigation mazeNavigation = new( )
        {
            Strategy = keepLeft
        };

        mazeNavigation.MakeMove( );
        mazeNavigation.MakeMove( );
        mazeNavigation.MakeMove( );

        mazeNavigation.Strategy = keepRight;
        mazeNavigation.MakeMove( );
        mazeNavigation.MakeMove( );
        mazeNavigation.MakeMove( );
    }
}