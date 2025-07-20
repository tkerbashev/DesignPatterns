namespace DesignPatterns.PatternExamples.Structural.Facade;

public class TurnLeftFacade
{
    private readonly Eyes eyes = new();
    private readonly Legs legs = new();
    private readonly Hands hands = new();

    public void TurnLeft()
    {
        Console.WriteLine("This is how you make a left turn:");

        hands.SignalLeft();
        eyes.LookOverLeftShoulder();
        legs.SlowDown();
        hands.TurnLeft();
    }
}
