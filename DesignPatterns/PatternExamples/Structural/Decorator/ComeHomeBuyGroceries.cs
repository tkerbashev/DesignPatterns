namespace DesignPatterns.PatternExamples.Structural.Decorator;

public class ComeHomeBuyGroceries : ComeHomeDecoratorBase
{
    public ComeHomeBuyGroceries(IComeHome comeHome) : base(comeHome) { }

    public override string Describe => base.Describe + " and buy some groceries on the way";
}
