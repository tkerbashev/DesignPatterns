namespace DesignPatterns.PatternExamples.Structural.Decorator;

public class ComeHomeHaveDringWithFriends : ComeHomeDecoratorBase
{
    public ComeHomeHaveDringWithFriends( IComeHome comeHome ) : base( comeHome ) { }

    public override string Describe => base.Describe + " but have a drink with friends first";
}
