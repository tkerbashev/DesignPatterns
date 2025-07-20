namespace DesignPatterns.PatternExamples.Behavioural.Strategy;

public class MazeNavigation
{
    public IMazeStrategy Strategy { get; set; } = new KeepLeft();

    public void MakeMove()
    {
        Console.WriteLine($"Making a move {Strategy.MazeStrategy()}");
    }
}
