namespace DesignPatterns.PatternExamples.Behavioural.State;

public class DrivingOnFlatRoad : DrivingType
{
    public DrivingOnFlatRoad( Car car )
    {
        Console.WriteLine( "Driving on a flat road:" );
        Car = car;
        RoadType = RoadType.Uphill;
    }
    public override void Drive( )
    {
        Console.WriteLine( "Drive carefully, using sparingly the gas and the breaks, trying to stay little below the speed limit" );
    }
}
