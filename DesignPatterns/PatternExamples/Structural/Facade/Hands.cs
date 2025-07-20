namespace DesignPatterns.PatternExamples.Structural.Facade;

public class Hands
{
    public void SignalLeft()
    {
        Console.WriteLine("Signal a left turn");
    }

    public void TurnLeft()
    {
        Console.WriteLine("Turn the wheel to make a left turn");
    }
}
