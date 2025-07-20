namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

public class PrivateHome : ICustomer
{
    public static string Name => "A Private Home";
    public void Accept( IVisitor visitor )
    {
        visitor.VisitPrivateHome( this );
    }
}
