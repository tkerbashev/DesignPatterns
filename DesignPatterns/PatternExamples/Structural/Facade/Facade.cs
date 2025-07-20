namespace DesignPatterns.PatternExamples.Structural.Facade;

internal class Facade: IPatternExample
{
    public void Demonstrate( )
    {
        TurnLeftFacade turnLeft = new( );
        turnLeft.TurnLeft( );
    }
}