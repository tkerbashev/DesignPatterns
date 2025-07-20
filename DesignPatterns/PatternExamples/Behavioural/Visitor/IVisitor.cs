namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

public interface IVisitor
{
    void VisttOffice( Office destination );
    void VisitPrivateHome( PrivateHome destination );
}
