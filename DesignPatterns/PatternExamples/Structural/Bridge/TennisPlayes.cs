namespace DesignPatterns.PatternExamples.Structural.Bridge;

public abstract class TennisPlayes
{
    public readonly IPlays _plays;

    public TennisPlayes(IPlays plays)
    {
        _plays = plays;
    }

    public abstract string DescribePlayer();
}
