namespace DesignPatterns.PatternExamples.Behavioural.State;

public class DrivingDownhill : DrivingType
{
    public DrivingDownhill( Car car )
    {
        Console.WriteLine( "Driving downhill:" );
        Car = car;
        RoadType = RoadType.Uphill;
    }
    public override void Drive( )
    {
        Console.WriteLine( "Drive carefully, using the breaks to stay below the speed limit" );
    }
}
