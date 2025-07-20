namespace DesignPatterns.PatternExamples.Behavioural.State;

public abstract class DrivingType
{
    public Car Car { get; protected set; } = null!;
    public RoadType RoadType { get; protected set; }
    public abstract void Drive();
}
