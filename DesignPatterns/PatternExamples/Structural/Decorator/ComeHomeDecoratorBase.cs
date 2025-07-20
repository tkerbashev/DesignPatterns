namespace DesignPatterns.PatternExamples.Structural.Decorator;

public abstract class ComeHomeDecoratorBase : IComeHome
{
    private readonly IComeHome _comeHome;

    public ComeHomeDecoratorBase(IComeHome comeHome)
    {
        _comeHome = comeHome;
    }
    public virtual string Describe => _comeHome.Describe;
}
