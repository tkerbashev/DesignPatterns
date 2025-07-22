namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

public interface IVisitor
{
    void VisttOffice( ICustomer destination );
    void VisitPrivateHome( ICustomer destination );
}
