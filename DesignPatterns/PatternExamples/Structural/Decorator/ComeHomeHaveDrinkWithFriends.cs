namespace DesignPatterns.PatternExamples.Structural.Decorator;

public class ComeHomeHaveDrinkWithFriends : ComeHomeDecoratorBase
{
    public ComeHomeHaveDrinkWithFriends( IComeHome comeHome ) : base( comeHome ) { }

    public override string Describe => base.Describe + " but have a drink with friends first";
}
