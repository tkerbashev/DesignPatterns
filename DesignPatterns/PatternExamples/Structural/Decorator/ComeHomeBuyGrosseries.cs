namespace DesignPatterns.PatternExamples.Structural.Decorator;

public class ComeHomeBuyGrosseries : ComeHomeDecoratorBase
{
    public ComeHomeBuyGrosseries(IComeHome comeHome) : base(comeHome) { }

    public override string Describe => base.Describe + " and buy some grosseries on the way";
}
