namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

public class Office : ICustomer
{
    public static string Name => "A Busy Office";
    public void Accept( IVisitor visitor )
    {
        visitor.VisttOffice( this );
    }
}
