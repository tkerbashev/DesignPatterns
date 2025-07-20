namespace DesignPatterns.PatternExamples.Structural.Bridge;

public class MalePlayer : TennisPlayes
{
    public MalePlayer(IPlays play) : base(play)
    {
    }

    public override string DescribePlayer( )
    {
        return "This player is Male and plays " + _plays.PreferredHand;
    }
}
