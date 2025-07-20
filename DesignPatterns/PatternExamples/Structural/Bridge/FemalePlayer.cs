namespace DesignPatterns.PatternExamples.Structural.Bridge;

public class FemalePlayer : TennisPlayes
{
    public FemalePlayer( IPlays play ) : base( play )
    {
    }

    public override string DescribePlayer( )
    {
        return "This player is Female and plays " + _plays.PreferredHand;
    }
}
