namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

public interface ICustomer
{
    void Accept(IVisitor visitor);
}
