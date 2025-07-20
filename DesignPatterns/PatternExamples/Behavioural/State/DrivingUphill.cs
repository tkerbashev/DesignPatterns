namespace DesignPatterns.PatternExamples.Behavioural.State;

public class DrivingUphill : DrivingType
{
    public DrivingUphill( Car car)
    {
        Console.WriteLine( "Driving uphill:" );
        Car = car;
        RoadType = RoadType.Uphill;
    }
    public override void Drive( )
    {
        Console.WriteLine("Drive with more gas to stay close to the speed limit");
    }
}
