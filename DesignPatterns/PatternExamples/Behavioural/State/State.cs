namespace DesignPatterns.PatternExamples.Behavioural.State;

internal class State: IPatternExample
{
    public void Demonstrate( )
    {
        Car myCar = new( );

        myCar.Drive( );

        myCar.ChangeRoadType( RoadType.Uphill ); ;
        myCar.Drive( );

        myCar.ChangeRoadType( RoadType.Downhill ); ;
        myCar.Drive( );
    }
}